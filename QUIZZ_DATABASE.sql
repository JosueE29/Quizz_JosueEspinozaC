CREATE DATABASE QuizzSchoolDatabase;
GO

USE QuizzSchoolDatabase;
GO


CREATE TABLE SCHOOL(
    SchoolId INT IDENTITY PRIMARY KEY,
    SchoolName VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(1000),
    Correo VARCHAR(50),
    Phone VARCHAR(50),
    PostCode VARCHAR(50),
    PostAddress VARCHAR(50)
);

CREATE TABLE CLASS (
    ClassId INT IDENTITY PRIMARY KEY,
    SchoolId INT NOT NULL,
    ClassName VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(1000),
    FOREIGN KEY (SchoolId) REFERENCES SCHOOL(SchoolId)
);

CREATE PROCEDURE ConsultaSchool
    @id INT
AS
BEGIN
    SELECT * FROM SCHOOL WHERE SchoolId = @id;
END;

INSERT INTO SCHOOL (SchoolName, Descripcion, Correo, Phone, PostCode, PostAddress)
VALUES ('Rafael Vargas Q', 'Hola', 'HGASH@GMAIL.COM', '88481201', '10101', 'ASDASD32123');

EXEC ConsultaSchool @id = 1;

CREATE PROCEDURE	
    @SchoolName VARCHAR(50),
    @Descripcion VARCHAR(1000),
    @Correo VARCHAR(50),
    @Phone VARCHAR(50),
    @PostCode VARCHAR(50),
    @PostAddress VARCHAR(50)
AS
BEGIN
    INSERT INTO SCHOOL (SchoolName, Descripcion, Correo, Phone, PostCode, PostAddress)
    VALUES (@SchoolName, @Descripcion, @Correo, @Phone, @PostCode, @PostAddress);
END;

CREATE PROCEDURE BorrarSchool
    @id INT
AS
BEGIN
    DELETE FROM SCHOOL WHERE SchoolId = @id;
END;

CREATE PROCEDURE ModificarSchool
    @id INT,
    @SchoolName VARCHAR(50),
    @Descripcion VARCHAR(1000),
    @Correo VARCHAR(50),
    @Phone VARCHAR(50),
    @PostCode VARCHAR(50),
    @PostAddress VARCHAR(50)
AS
BEGIN
    UPDATE SCHOOL
    SET SchoolName = @SchoolName,
        Descripcion = @Descripcion,
        Correo = @Correo,
        Phone = @Phone,
        PostCode = @PostCode,
        PostAddress = @PostAddress
    WHERE SchoolId = @id;
END;

CREATE PROCEDURE ConsultaClass
    @SchoolId INT
AS
BEGIN
    SELECT * FROM CLASS WHERE SchoolId = @SchoolId;
END;

CREATE PROCEDURE InsertarClass
    @SchoolId INT,
    @ClassName VARCHAR(50),
    @Descripcion VARCHAR(1000)
AS
BEGIN
    INSERT INTO CLASS (SchoolId, ClassName, Descripcion)
    VALUES (@SchoolId, @ClassName, @Descripcion);
END;

CREATE PROCEDURE BorrarClass
    @id INT
AS
BEGIN
    DELETE FROM CLASS WHERE ClassId = @id;
END;

CREATE PROCEDURE ModificarClass
    @id INT,
    @ClassName VARCHAR(50),
    @Descripcion VARCHAR(1000)
AS
BEGIN
    UPDATE CLASS
    SET ClassName = @ClassName,
        Descripcion = @Descripcion
    WHERE ClassId = @id;
END;
