using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Web;

namespace QuizzProgra.Modelo
{
    public class CLASSCLS
    {
        public int ClassId { get; set; }
        public int SchoolId { get; set; }
        public string ClassName { get; set; }
        public string Descripcion { get; set; }
    }
}
