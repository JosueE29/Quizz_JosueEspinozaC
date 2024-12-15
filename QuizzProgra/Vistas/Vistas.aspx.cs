using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/*Josue Espinoza Castillo*/
/*Cedula:305610426*/
/*Curso INFO-104*/
/*Prof.Benjamin Curling*/
/*QUIZZ */
namespace QuizzProgra.Vistas
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGridSchool();
            LlenarGridClass();
        }
        protected void LlenarGridSchool()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM SCHOOL"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridViewSchool.DataSource = dt;
                            GridViewSchool.DataBind();  
                        }
                    }
                }
            }
        }
        protected void LlenarGridClass()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM CLASS"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridViewClass.DataSource = dt;
                            GridViewClass.DataBind();
                        }
                    }
                }
            }
        }
        protected void AgregarSC_Click(object sender, EventArgs e)
        {
            string schoolName = NameSchoolTextBox.Text;
            string descripcion = DescriptionSchoolTextBox.Text;
            string correo = EmailSchoolTextBox.Text;
            string phone = PhoneSchoolTextBox.Text;
            string postCode = PostCodeTextBox.Text;
            string postAddress = PostAddressTextBox.Text;


            int resultado = Logica.SCHOOL.InsertarSchool(schoolName, descripcion, correo, phone, postCode, postAddress);

            if (resultado > 0)
            {
                Response.Write("<script>alert('Escuela agregada exitosamente.');</script>");
                LlenarGridSchool(); 


                NameSchoolTextBox.Text = "";
                DescriptionSchoolTextBox.Text = "";
                EmailSchoolTextBox.Text = "";
                PhoneSchoolTextBox.Text = "";
                PostCodeTextBox.Text = "";
                PostAddressTextBox.Text = "";
            }
            else
            {
                Response.Write("<script>alert('Ocurrió un error al agregar la escuela. Verifique los datos.');</script>");
            }
        }

 
        protected void BorrarSC_Click(object sender, EventArgs e)
        {
            int schoolId;


            if (!int.TryParse(SchoolIDTextBox.Text, out schoolId))
            {
                Response.Write("<script>alert('El ID de la escuela debe ser un número válido.');</script>");
                return;
            }

            int resultado = Logica.SCHOOL.BorrarSchool(schoolId);

            if (resultado > 0)
            {
                Response.Write("<script>alert('Escuela eliminada exitosamente.');</script>");
                LlenarGridSchool();

                SchoolIDTextBox.Text = "";
            }
            else
            {
                Response.Write("<script>alert('Ocurrió un error al eliminar la escuela. Verifique el ID.');</script>");
            }
        }

        protected void ModificarSC_Click(object sender, EventArgs e)
        {
            int schoolId;
            string schoolName = NameSchoolTextBox.Text;
            string descripcion = DescriptionSchoolTextBox.Text;
            string correo = EmailSchoolTextBox.Text;
            string phone = PhoneSchoolTextBox.Text;
            string postCode = PostCodeTextBox.Text;
            string postAddress = PostAddressTextBox.Text;

            if (!int.TryParse(SchoolIDTextBox.Text, out schoolId))
            {
                Response.Write("<script>alert('El ID de la escuela debe ser un número válido.');</script>");
                return;
            }

            int resultado = Logica.SCHOOL.ModificarSchool(schoolId, schoolName, descripcion, correo, phone, postCode, postAddress);

            if (resultado > 0)
            {
                Response.Write("<script>alert('Escuela modificada exitosamente.');</script>");
                LlenarGridSchool(); 

                
                SchoolIDTextBox.Text = "";
                NameSchoolTextBox.Text = "";
                DescriptionSchoolTextBox.Text = "";
                EmailSchoolTextBox.Text = "";
                PhoneSchoolTextBox.Text = "";
                PostCodeTextBox.Text = "";
                PostAddressTextBox.Text = "";
            }
            else
            {
                Response.Write("<script>alert('Error al modificar la escuela. Verifique los datos.');</script>");
            }
        }

        protected void AgregarC_Click(object sender, EventArgs e)
        {
            int schoolId;
            string className = NameClassTextBox.Text;
            string descripcion = DescriptionClassTextBox.Text;

            if (!int.TryParse(ClassIDTextBox.Text, out schoolId))
            {
                Response.Write("<script>alert('El ID de la escuela debe ser un número válido.');</script>");
                return;
            }

            int resultado = Logica.CLASS.InsertarClass(schoolId, className, descripcion);

            if (resultado > 0)
            {
                Response.Write("<script>alert('Clase agregada exitosamente.');</script>");
                LlenarGridClass(); 

                NameClassTextBox.Text = "";
                DescriptionClassTextBox.Text = "";
                ClassIDTextBox.Text = "";
                LlenarGridClass();
            }
            else
            {
                Response.Write("<script>alert('Ocurrió un error al agregar la clase. Verifique los datos.');</script>");
            }
        }

        protected void BorrarC_Click(object sender, EventArgs e)
        {
            int classId;


            if (!int.TryParse(ClassIDTextBox.Text, out classId))
            {
                Response.Write("<script>alert('El ID de la clase debe ser un número válido.');</script>");
                return;
            }

     
            int resultado = Logica.CLASS.BorrarClass(classId);

            if (resultado > 0)
            {
                Response.Write("<script>alert('Clase eliminada exitosamente.');</script>");
                LlenarGridClass();

                ClassIDTextBox.Text = "";
            }
            else
            {
                Response.Write("<script>alert('Ocurrió un error al eliminar la clase. Verifique el ID.');</script>");
            }
        }

    }
}