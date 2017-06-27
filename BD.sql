USE master
go
IF EXISTS(select * from sys.databases where name='BD_TESIS')
alter database BD_TESIS set single_user with rollback immediate
alter database BD_TESIS set multi_user
DROP DATABASE BD_TESIS
GO
CREATE DATABASE BD_TESIS
GO
USE BD_TESIS
GO
-- CREAR TABLAS 
-- NOT NULL NO PUEDE SER VACIO
-- UNIQUE DEBE SER UNICO 
-- PRIMARY KEY -LLAVE PRIMARIA
-- IDENTITY(a,b) IDENTITY ES LA LLAVE PRIMARIA SERA AUTOGENERADA 
-- A EL NUMERO DE INICIO
-- B EL AUMENTO POR CADA INTENTO
-- NOMBRE_COLUMNA TIPO NOT NULL O NULL 



-- TABLAS DEL SISTEMA PARA LA SEGURIDAD
CREATE TABLE ROL_USUARIO(
ID INT IDENTITY(1,1) PRIMARY KEY,
NOMBRES VARCHAR(100) NOT NULL,
DESCRIPCION VARCHAR(200) NULL,
--FECHA_REGISTRO DATETIME NOT NULL DEFAULT GETDATE(),
--ELIMINADO BIT DEFAULT 0
)
GO
CREATE TABLE USUARIO(
ID INT IDENTITY(1,1) PRIMARY KEY,
ROL_USUARIO_ID INT REFERENCES ROL_USUARIO  NOT NULL,
USER_NAME VARCHAR(100) UNIQUE NOT NULL ,
PASSWORD VARCHAR(200) NOT NULL,
CORREO VARCHAR(200) NOT NULL ,
NOMBRES VARCHAR(100) NOT NULL,
APELLIDOS VARCHAR(200) NOT NULL,
FECHA_NACIMIENTO DATE  NULL,
URL_AVATAR VARCHAR(200) NULL,
TELEFONO VARCHAR(100) NULL,
HABILITADO BIT DEFAULT 1,
--FECHA_REGISTRO DATETIME NOT NULL DEFAULT GETDATE(),
--ELIMINADO BIT DEFAULT 0 -- eN UNA BD NO SE DEBEN BORRAR LOS DATOS 
-- LO QUE SE HACE ES "OCULTARLOS "
)
GO
CREATE TABLE PROGRAMA_POSTGRADO(
ID INT IDENTITY(1,1) PRIMARY KEY,
NOMBRE_PROGRAMA VARCHAR(100) NOT NULL,
PLAN_CURRICULAR VARCHAR(100) NULL,
--FECHA_REGISTRO DATETIME NOT NULL DEFAULT GETDATE(),
--ELIMINADO BIT DEFAULT 0
)
GO
-- TABLAS PARA EL PROCESO
CREATE TABLE ALUMNO(
ID INT IDENTITY(1,1) PRIMARY KEY,
CODIGO VARCHAR(100) NOT NULL UNIQUE,
NOMBRES VARCHAR(100) NOT NULL,
APELLIDOS VARCHAR(200) NOT NULL,
TELEFONO VARCHAR(100) NULL,
CORREO VARCHAR(200) NOT NULL ,
FECHA_NACIMIENTO DATE  NULL,
TIPO_DOCUMENTO VARCHAR(100) NOT NULL,
NUMERO_DOCUMENTO VARCHAR(100) NOT NULL,
GRADO_ACADEMICO VARCHAR(100) NOT NULL,
PROGRAMA_POSTGRADO_ID INT REFERENCES PROGRAMA_POSTGRADO  NOT NULL,
URL_FOTO VARCHAR(200) NULL,
FECHA_REGISTRO DATETIME NOT NULL DEFAULT GETDATE(),
ELIMINADO BIT DEFAULT 0
)
GO
CREATE TABLE SOLICITUD_ESTADO(
ID INT IDENTITY(1,1) PRIMARY KEY,
NOMBRE VARCHAR(100) NOT NULL,
DESCRIPCION VARCHAR(200) NOT NULL,
FECHA_REGISTRO DATETIME NOT NULL DEFAULT GETDATE(),
ELIMINADO BIT DEFAULT 0
)

GO

CREATE TABLE SOLICITUD(
ID INT IDENTITY(1,1) PRIMARY KEY,
CODIGO VARCHAR(100) NOT NULL UNIQUE,
FECHA_EMISION DATE NOT NULL DEFAULT GETDATE(),
CODIGO_ALUMNO_SOL VARCHAR(100) NOT NULL,
NOMBRES_SOL VARCHAR(100) NOT NULL,
APELLIDOS_SOL VARCHAR(200) NOT NULL,
TIPO_DOCUMENTO_SOL VARCHAR(100) NOT NULL ,
NUMERO_DOCUMENTO_SOL VARCHAR(100) NOT NULL,
GRADO_ACADEMICO_SOL VARCHAR(100) NOT NULL,
PROGRAMA_POSTGRADO VARCHAR(100) NOT NULL,
NOMBRE_TESIS VARCHAR(100) NOT NULL,
OBSERVACIONES VARCHAR(200) NULL,
ALUMNO_ID INT REFERENCES ALUMNO NOT NULL,
SOLICITUD_ESTADO_ID INT REFERENCES SOLICITUD_ESTADO NOT NULL,
NOMBRE_ESTADO VARCHAR(100) NOT NULL,
FECHA_PAGO DATETIME NULL,
FECHA_EVALUACION DATETIME NULL,
MOTIVO_ANULACION VARCHAR(200) NULL,
MOTIVO_EVALUACION VARCHAR(200) NULL,
FECHA_FINALIZACION DATETIME NULL,
FECHA_REGISTRO DATETIME NOT NULL DEFAULT GETDATE(),
ELIMINADO BIT DEFAULT 0
)


GO
CREATE TABLE TESIS_TEMA(
ID INT IDENTITY(1,1) PRIMARY KEY,
NOMBRE VARCHAR(100) NOT NULL,
FECHA_REGISTRO DATETIME NOT NULL DEFAULT GETDATE(),
ELIMINADO BIT DEFAULT 0
)
GO

CREATE TABLE SOLICITUD_TEMAS(
ID INT IDENTITY(1,1) PRIMARY KEY,
SOLICITUD_ID INT REFERENCES SOLICITUD NOT NULL,
TESIS_TEMA_ID INT REFERENCES TESIS_TEMA NOT NULL,
FECHA_REGISTRO DATETIME NOT NULL DEFAULT GETDATE(),
ELIMINADO BIT DEFAULT 0
) 
GO
CREATE TABLE PROFESOR(
ID INT IDENTITY(1,1) PRIMARY KEY,
CODIGO VARCHAR(100) NOT NULL UNIQUE,
NOMBRES VARCHAR(100) NOT NULL,
APELLIDOS VARCHAR(200) NOT NULL,
MAESTRIA VARCHAR(200)  NULL,
DOCTORADO VARCHAR(200)  NULL,
OBSERVACIONES VARCHAR(200) NULL,
TELEFONO VARCHAR(100) NULL,
CORREO VARCHAR(200) NOT NULL ,
URL_FOTO VARCHAR(200) NULL,
FECHA_REGISTRO DATETIME NOT NULL DEFAULT GETDATE(),
ELIMINADO BIT DEFAULT 0
)



CREATE TABLE HORARIO_JURADO_SUSTENTACION(
ID INT IDENTITY(1,1) PRIMARY KEY,
PROFESOR_ID INT REFERENCES PROFESOR NOT NULL,
ES_PRESIDENTE BIT NOT NULL,
SOLICITUD_ID INT REFERENCES SOLICITUD NOT NULL,
LUGAR VARCHAR(200) NOT NULL, 
FECHA DATE NOT NULL,
HORA TIME NOT NULL,
FECHA_REGISTRO DATETIME NOT NULL DEFAULT GETDATE(),
ELIMINADO BIT DEFAULT 0
)
GO

CREATE TABLE FORMA_PAGO(
ID INT IDENTITY(1,1) PRIMARY KEY,
NOMBRE VARCHAR(100) NOT NULL,
FECHA_REGISTRO DATETIME NOT NULL DEFAULT GETDATE(),
ELIMINADO BIT DEFAULT 0
)
GO

CREATE TABLE PAGO_SOLICITUD(
ID INT IDENTITY(1,1) PRIMARY KEY,
SOLICITUD_ID INT REFERENCES SOLICITUD NOT NULL,
FORMA_PAGO_ID INT REFERENCES FORMA_PAGO NOT NULL,
SERIE VARCHAR(100) NOT NULL,
NUMERO VARCHAR(100) NOT NULL,
MONTO DECIMAL(10,2) NOT NULL,
FECHA_PAGO DATETIME NOT NULL,
FOTO_ADJUNTA VARCHAR(200) NULL,
FECHA_REGISTRO DATETIME NOT NULL DEFAULT GETDATE(),
ELIMINADO BIT DEFAULT 0
)
GO
CREATE TABLE SERIE_DOCUMENTO(
ID INT IDENTITY(1,1) PRIMARY KEY,
NOMBRE VARCHAR(100) NOT NULL,
TIPO VARCHAR(200) NOT NULL,
SERIE VARCHAR(100) NOT NULL,
NUMERO VARCHAR(100) NOT NULL,
FECHA_REGISTRO DATETIME NOT NULL DEFAULT GETDATE(),
ELIMINADO BIT DEFAULT 0
)
GO
--PROCEDURES PARA LOS ALUMNOS
CREATE PROCEDURE OBTENER_ALUMNOS_HABILITADOS
AS
BEGIN
  SELECT A.ID,A.CODIGO,A.NOMBRES,A.APELLIDOS,A.CORREO,
  A.TIPO_DOCUMENTO,A.NUMERO_DOCUMENTO,
  P.NOMBRE_PROGRAMA,P.PLAN_CURRICULAR,A.GRADO_ACADEMICO,
  A.URL_FOTO
  FROM ALUMNO A INNER JOIN 
  PROGRAMA_POSTGRADO P 
  ON A.PROGRAMA_POSTGRADO_ID = P.ID
  WHERE ELIMINADO=0 ORDER BY A.CODIGO DESC 
END
exec OBTENER_ALUMNOS_HABILITADOS
GO
CREATE PROCEDURE OBTENER_ALUMNOS_TODOS
AS
BEGIN
  SELECT A.ID,A.CODIGO,A.NOMBRES,A.APELLIDOS,A.CORREO,
  A.TIPO_DOCUMENTO,A.NUMERO_DOCUMENTO,
  P.NOMBRE_PROGRAMA,P.PLAN_CURRICULAR,A.GRADO_ACADEMICO,
  A.URL_FOTO
  FROM ALUMNO A INNER JOIN 
  PROGRAMA_POSTGRADO P 
  ON A.PROGRAMA_POSTGRADO_ID = P.ID
  ORDER BY A.CODIGO DESC 
END
GO

CREATE PROCEDURE OBTENER_ALUMNO_POR_CODIGO
@CODIGO_ALUMNO VARCHAR(100) 
AS
BEGIN
  SELECT A.ID,A.CODIGO,A.NOMBRES,A.APELLIDOS,A.CORREO,
  A.TIPO_DOCUMENTO,A.NUMERO_DOCUMENTO,
  P.NOMBRE_PROGRAMA,P.PLAN_CURRICULAR,A.GRADO_ACADEMICO,
  A.URL_FOTO
  FROM ALUMNO A INNER JOIN 
  PROGRAMA_POSTGRADO P 
  ON A.PROGRAMA_POSTGRADO_ID = P.ID
  WHERE ELIMINADO=0  AND A.CODIGO=@CODIGO_ALUMNO
END

GO 
CREATE PROCEDURE OBTENER_ALUMNO_POR_ID
@ID INT
AS
BEGIN
  SELECT A.ID,A.CODIGO,A.NOMBRES,A.APELLIDOS,A.CORREO,
  A.TIPO_DOCUMENTO,A.NUMERO_DOCUMENTO,
  P.NOMBRE_PROGRAMA,P.PLAN_CURRICULAR,A.GRADO_ACADEMICO,
  A.URL_FOTO
  FROM ALUMNO A INNER JOIN 
  PROGRAMA_POSTGRADO P 
  ON A.PROGRAMA_POSTGRADO_ID = P.ID
  WHERE ELIMINADO=0  AND A.ID=@ID
END
-- SERIE DOCUMENTO
GO
CREATE PROCEDURE ULTIMO_NUMERO_SERIE
@TIPO VARCHAR(100) 
AS BEGIN
	SELECT TOP 1 ID,SERIE,NUMERO
	FROM SERIE_DOCUMENTO WHERE 
	TIPO = @TIPO AND ELIMINADO=0 
END
GO
CREATE PROCEDURE MODIFICAR_NUMERO_SERIE
@ID INT , @SERIE VARCHAR(100) , @NUMERO VARCHAR(100)
AS BEGIN
	UPDATE SERIE_DOCUMENTO SET SERIE=@SERIE,NUMERO=@NUMERO WHERE ID=@ID
END
GO
-- ESTADO SOLCIITUD
CREATE PROCEDURE OBTENER_ESTADOSOLICITUD_POR_ID
@ID INT 
AS
BEGIN
SELECT ID,NOMBRE FROM SOLICITUD_ESTADO 
WHERE ID=@ID AND ELIMINADO=0
END
GO
-- SOLICITUD
CREATE PROCEDURE REGISTRAR_SOLICITUD
@CODIGO VARCHAR(100),
@FECHA_EMISION DATE,
@CODIGO_ALUMNO VARCHAR(100),
@NOMBRES_SOL VARCHAR(100),
@APELLIDOS_SOL VARCHAR(200),
@TIPO_DOCUMENTO_SOL VARCHAR(100),
@NUMERO_DOCUMENTO_SOL VARCHAR(100),
@GRADO_ACADEMICO_SOL VARCHAR(100),
@PROGRAMA_POSTGRADO VARCHAR(100),
@NOMBRE_TESIS VARCHAR(100),
@OBSERVACIONES VARCHAR(200),
@ALUMNO_ID INT ,
@SOLICITUD_ESTADO_ID INT ,
@NOMBRE_ESTADO VARCHAR(100),
@ID INT OUTPUT
AS
BEGIN
INSERT INTO SOLICITUD
(CODIGO,
FECHA_EMISION,
CODIGO_ALUMNO_SOL,
NOMBRES_SOL,
APELLIDOS_SOL,
TIPO_DOCUMENTO_SOL,
NUMERO_DOCUMENTO_SOL,
GRADO_ACADEMICO_SOL,
PROGRAMA_POSTGRADO,
NOMBRE_TESIS,
OBSERVACIONES,
ALUMNO_ID,
SOLICITUD_ESTADO_ID,
NOMBRE_ESTADO,
FECHA_REGISTRO,
ELIMINADO
)
VALUES (
@CODIGO,
@FECHA_EMISION,
@CODIGO_ALUMNO,
@NOMBRES_SOL,
@APELLIDOS_SOL,
@TIPO_DOCUMENTO_SOL,
@NUMERO_DOCUMENTO_SOL,
@GRADO_ACADEMICO_SOL,
@PROGRAMA_POSTGRADO,
@NOMBRE_TESIS,
@OBSERVACIONES,
@ALUMNO_ID,
@SOLICITUD_ESTADO_ID,
@NOMBRE_ESTADO,
GETDATE(),
0
)
SET @ID = scope_identity() ;
END
GO
CREATE PROCEDURE OBTENER_SOLICITUDES_POR_ESTADO
@ESTADO_ID INT 
AS
BEGIN
SELECT 
S.ID,
S.CODIGO,
S.FECHA_EMISION,
S.CODIGO_ALUMNO_SOL,
S.NOMBRES_SOL,
S.APELLIDOS_SOL,
S.NUMERO_DOCUMENTO_SOL,
S.NOMBRE_TESIS,
S.NOMBRE_ESTADO,
S.FECHA_PAGO,
S.FECHA_EVALUACION,
S.FECHA_FINALIZACION,
S.PROGRAMA_POSTGRADO,
S.MOTIVO_EVALUACION,
S.OBSERVACIONES,
A.URL_FOTO
FROM SOLICITUD S 
inner join ALUMNO A
ON A.ID=S.ALUMNO_ID
WHERE S.SOLICITUD_ESTADO_ID = @ESTADO_ID
AND S.ELIMINADO = 0
END
GO

exec OBTENER_SOLICITUDES_POR_ESTADO 1

go
-- TESIS_TEMA
CREATE PROCEDURE OBTENER_TEMA_TESIS_HABILITADOS
AS
BEGIN
SELECT ID,NOMBRE FROM TESIS_TEMA 
WHERE ELIMINADO=0 ORDER BY NOMBRE DESC
END
GO

CREATE PROCEDURE REGISTRAR_SOLICITUD_TEMA
@SOLICITUD_ID INT ,
@TEMA_ID INT 
AS
BEGIN
INSERT INTO SOLICITUD_TEMAS(
SOLICITUD_ID,
TESIS_TEMA_ID,
FECHA_REGISTRO,
ELIMINADO
)
VALUES(
@SOLICITUD_ID,
@TEMA_ID,
GETDATE(),
0
);
END
GO
CREATE PROCEDURE OBTENER_TEMAS_POR_SOLICITUD
@SOLICITUD_ID INT 
AS
BEGIN
SELECT  
T.NOMBRE
FROM SOLICITUD_TEMAS ST INNER JOIN
TESIS_TEMA T 
ON ST.TESIS_TEMA_ID=T.ID
WHERE ST.SOLICITUD_ID = @SOLICITUD_ID
END
GO
-- FORMA_PAGO
CREATE PROCEDURE OBTENER_FORMA_PAGO_HABILITADOS
AS
BEGIN
SELECT ID,NOMBRE FROM FORMA_PAGO 
WHERE ELIMINADO=0 ORDER BY NOMBRE DESC
END
GO
-- REGISTRAR PAGO
CREATE PROCEDURE REGISTRAR_PAGO
@SOLICITUD_ID INT ,
@FORMA_PAGO_ID INT,
@SERIE VARCHAR(100),
@NUMERO VARCHAR(100),
@MONTO DECIMAL,
@FECHA_PAGO DATETIME,
@FOTO_ADJUNTA VARCHAR(200)
AS
BEGIN
INSERT INTO PAGO_SOLICITUD
(
SOLICITUD_ID,
FORMA_PAGO_ID,
SERIE,
NUMERO,
MONTO,
FECHA_PAGO,
FOTO_ADJUNTA,
FECHA_REGISTRO,
ELIMINADO
)VALUES
(
@SOLICITUD_ID,
@FORMA_PAGO_ID,
@SERIE,
@NUMERO,
@MONTO,
@FECHA_PAGO,
@FOTO_ADJUNTA,
GETDATE(),
0
);
END
GO
-- ACTUALIZAR SALDO SOLICITUD
CREATE PROCEDURE CAMBIAR_ESTADO_CANCELADO_SOLICITUD
@SOLICITUD_ID INT ,
@ESTADO_ID INT,
@NOMBRE_RESTADO VARCHAR(100),
@FECHA_PAGO DATETIME
AS
BEGIN
UPDATE SOLICITUD 
SET SOLICITUD_ESTADO_ID = @ESTADO_ID,
NOMBRE_ESTADO = @NOMBRE_RESTADO ,
FECHA_PAGO = @FECHA_PAGO
WHERE ID = @SOLICITUD_ID
END
GO
-- ACTUALIZAR 
CREATE PROCEDURE REGISTRAR_EVALUACION_SOLICITUD
@SOLICITUD_ID INT ,
@ESTADO_ID INT,
@NOMBRE_RESTADO VARCHAR(100),
@FECHA_EVALUACION DATETIME,
@MOTIVO_EVALUACION VARCHAR(200)
AS
BEGIN
UPDATE SOLICITUD 
SET SOLICITUD_ESTADO_ID = @ESTADO_ID,
NOMBRE_ESTADO = @NOMBRE_RESTADO ,
FECHA_EVALUACION = @FECHA_EVALUACION,
MOTIVO_EVALUACION = @MOTIVO_EVALUACION
WHERE ID = @SOLICITUD_ID
END
GO



select *from FORMA_PAGO;

USE BD_TESIS;

USE BD_TESIS;
INSERT INTO PROGRAMA_POSTGRADO
(NOMBRE_PROGRAMA,PLAN_CURRICULAR)
VALUES ('MAESTR�A EN INGENIER�A INDUSTRIAL','PLAN DE ESTUDIOS 2010');
INSERT INTO PROGRAMA_POSTGRADO
(NOMBRE_PROGRAMA,PLAN_CURRICULAR)
VALUES ('MAESTR�A EN DIRECCI�N DE EMPRESAS INDUSTRIALES Y DE SERVICIOS','PLAN DE ESTUDIOS 2010');
INSERT INTO PROGRAMA_POSTGRADO
(NOMBRE_PROGRAMA,PLAN_CURRICULAR)
VALUES ('MAESTR�A EN GESTI�N DE OPERACIONES Y SERVICIOS LOG�STICOS','PLAN DE ESTUDIOS 2010');
INSERT INTO PROGRAMA_POSTGRADO
(NOMBRE_PROGRAMA,PLAN_CURRICULAR)
VALUES ('MAESTR�A PROFESIONAL EN PREVENCI�N DE RIESGOS LABORALES Y AMBIENTALES','PLAN DE ESTUDIOS 2010');

GO



INSERT INTO ALUMNO 
(CODIGO,NOMBRES,APELLIDOS,TELEFONO,CORREO,FECHA_NACIMIENTO,TIPO_DOCUMENTO,NUMERO_DOCUMENTO,GRADO_ACADEMICO,PROGRAMA_POSTGRADO_ID,URL_FOTO)
VALUES ('12172818','PAOLA CINTHYA','ALARCON FUENTES','5551212','paola.alarcon@industrial.unmsm.pe','25/02/1990','DNI','71446373','BACHILLER','1','1.jpg');

INSERT INTO ALUMNO 
(CODIGO,NOMBRES,APELLIDOS,TELEFONO,CORREO,FECHA_NACIMIENTO,TIPO_DOCUMENTO,NUMERO_DOCUMENTO,GRADO_ACADEMICO,PROGRAMA_POSTGRADO_ID,URL_FOTO)
VALUES ('12170906','ANGELA MARIA','ALDUS CANTO','5555389','angela.aldus@industrial.unmsm.pe','22/05/1989','DNI','48223279','BACHILLER','2','2.jpg');

INSERT INTO ALUMNO 
(CODIGO,NOMBRES,APELLIDOS,TELEFONO,CORREO,FECHA_NACIMIENTO,TIPO_DOCUMENTO,NUMERO_DOCUMENTO,GRADO_ACADEMICO,PROGRAMA_POSTGRADO_ID,URL_FOTO)
VALUES ('12176949','JOSE ALBERTO','ARROYO MAURY','5814902','jose.arroyo@industrial.unmsm.pe','1/01/1987','DNI','10123558','TITULADO','3','3.jpg');

INSERT INTO ALUMNO 
(CODIGO,NOMBRES,APELLIDOS,TELEFONO,CORREO,FECHA_NACIMIENTO,TIPO_DOCUMENTO,NUMERO_DOCUMENTO,GRADO_ACADEMICO,PROGRAMA_POSTGRADO_ID,URL_FOTO)
VALUES ('12171930','LUIS CARLOS','CARPIO ZAMUDIO','4684157','luis.carpio@industrial.unmsm.pe','13/11/1984','DNI','65438765','TITULADO','4','4.jpg');

INSERT INTO ALUMNO 
(CODIGO,NOMBRES,APELLIDOS,TELEFONO,CORREO,FECHA_NACIMIENTO,TIPO_DOCUMENTO,NUMERO_DOCUMENTO,GRADO_ACADEMICO,PROGRAMA_POSTGRADO_ID,URL_FOTO)
VALUES ('12173757','LISSET MARILYN','ARROYO MAURY','4419208','lisset.caycho@industrial.unmsm.pe','11/05/1989','DNI','97454012','BACHILLER','1','5.jpg');

INSERT INTO ALUMNO 
(CODIGO,NOMBRES,APELLIDOS,TELEFONO,CORREO,FECHA_NACIMIENTO,TIPO_DOCUMENTO,NUMERO_DOCUMENTO,GRADO_ACADEMICO,PROGRAMA_POSTGRADO_ID,URL_FOTO)
VALUES ('12170483','BEGONA SAORI','CIEZA NUNEZ','4781946','begona.cieza@industrial.unmsm.pe','1/05/1983','DNI','27380056','TITULADO','2','6.jpg');

INSERT INTO ALUMNO 
(CODIGO,NOMBRES,APELLIDOS,TELEFONO,CORREO,FECHA_NACIMIENTO,TIPO_DOCUMENTO,NUMERO_DOCUMENTO,GRADO_ACADEMICO,PROGRAMA_POSTGRADO_ID,URL_FOTO)
VALUES ('12172631','YURLIK ROGER','CORDOVA LAOS','3132874','yurlik.cordova@industrial.unmsm.pe','18/12/1989','DNI','10303418','BACHILLER','3','7.jpg');

INSERT INTO ALUMNO 
(CODIGO,NOMBRES,APELLIDOS,TELEFONO,CORREO,FECHA_NACIMIENTO,TIPO_DOCUMENTO,NUMERO_DOCUMENTO,GRADO_ACADEMICO,PROGRAMA_POSTGRADO_ID,URL_FOTO)
VALUES ('11179460','JUANA RAFAELA','MIRANDA CASAS','5419208','juana.miranda@industrial.unmsm.pe','30/05/1970','CARNET DE EXTRANJERIA','15772269','TITULADO','3','8.jpg');

INSERT INTO ALUMNO 
(CODIGO,NOMBRES,APELLIDOS,TELEFONO,CORREO,FECHA_NACIMIENTO,TIPO_DOCUMENTO,NUMERO_DOCUMENTO,GRADO_ACADEMICO,PROGRAMA_POSTGRADO_ID,URL_FOTO)
VALUES ('11174143','CELESTE','ZURCO SALEYO','6716213','celeste.zurco@industrial.unmsm.pe','5/05/1986','CARNET DE EXTRANJERIA','45100153','TITULADO','2','9.jpg');

INSERT INTO ALUMNO 
(CODIGO,NOMBRES,APELLIDOS,TELEFONO,CORREO,FECHA_NACIMIENTO,TIPO_DOCUMENTO,NUMERO_DOCUMENTO,GRADO_ACADEMICO,PROGRAMA_POSTGRADO_ID,URL_FOTO)
VALUES ('11171450','HIROMI','ZAPATA NOVOA','6719999','hiromi.zapata@industrial.unmsm.pe','30/04/1980','DNI','34734385','TITULADO','1','10.jpg');

INSERT INTO ALUMNO 
(CODIGO,NOMBRES,APELLIDOS,TELEFONO,CORREO,FECHA_NACIMIENTO,TIPO_DOCUMENTO,NUMERO_DOCUMENTO,GRADO_ACADEMICO,PROGRAMA_POSTGRADO_ID,URL_FOTO)
VALUES ('11170396','VICTOR GUADALUPE','MORA ACEVEDO','4782020','victor.mora@industrial.unmsm.pe','19/10/1975','DNI','73214266','TITULADO','1','11.jpg');

INSERT INTO ALUMNO 
(CODIGO,NOMBRES,APELLIDOS,TELEFONO,CORREO,FECHA_NACIMIENTO,TIPO_DOCUMENTO,NUMERO_DOCUMENTO,GRADO_ACADEMICO,PROGRAMA_POSTGRADO_ID,URL_FOTO)
VALUES ('11173472','PATRICIO','TAPIA ALVA','3130050','patricio.tapia@industrial.unmsm.pe','24/05/1990','DNI','73214266','BACHILLER','1','12.jpg');

INSERT INTO ALUMNO 
(CODIGO,NOMBRES,APELLIDOS,TELEFONO,CORREO,FECHA_NACIMIENTO,TIPO_DOCUMENTO,NUMERO_DOCUMENTO,GRADO_ACADEMICO,PROGRAMA_POSTGRADO_ID,URL_FOTO)
VALUES ('11171565','BENJAMIN AURELIO','TOVAR JIMENEZ','7710135','benjamin.tovar@industrial.unmsm.pe','26/03/1989','DNI','16806708','BACHILLER','2','13.jpg');

INSERT INTO ALUMNO 
(CODIGO,NOMBRES,APELLIDOS,TELEFONO,CORREO,FECHA_NACIMIENTO,TIPO_DOCUMENTO,NUMERO_DOCUMENTO,GRADO_ACADEMICO,PROGRAMA_POSTGRADO_ID,URL_FOTO)
VALUES ('11175147','DAVID','VERGARA COHEN','6719135','david.vergara@industrial.unmsm.pe','14/02/1980','DNI','62383370','TITULADO','1','14.jpg');


USE BD_TESIS;
INSERT INTO ROL_USUARIO
(NOMBRES,DESCRIPCION)
VALUES ('RECEPCIONISTA','Encargado de recibir la solicitud generada por el alumno y registrarla en el sistema');
INSERT INTO ROL_USUARIO
(NOMBRES,DESCRIPCION)
VALUES ('CAJERO','Encargado de recibir el pago en efectivo o el comprobante de pago si realiza deposito a cuenta corriente.');
INSERT INTO ROL_USUARIO
(NOMBRES,DESCRIPCION)
VALUES ('DIRECTOR DE LA UPG','Evaluar� la solicitud, asignar� los miembros del jurado examinador de tesis y generar� el horario de exposici�n de tesis.');
INSERT INTO ROL_USUARIO
(NOMBRES,DESCRIPCION)
VALUES ('ADMINISTRADOR','Encargado de agregar usuario, modificar usuario, eliminar usuario y asegurar el correcto funcionamiento del sistema');

INSERT INTO SERIE_DOCUMENTO(TIPO,NOMBRE,SERIE,NUMERO)
VALUES ('SOLICITUD','SOLICITUD DE TESUS','001','00000000');



USE BD_TESIS;
INSERT INTO SOLICITUD_ESTADO
(NOMBRE,DESCRIPCION)
VALUES ('GENERADA','La solicitud ha sido generada por el alumno');

INSERT INTO SOLICITUD_ESTADO
(NOMBRE,DESCRIPCION)
VALUES ('ANULADA','La solicitud ha sido anulada por realizar el pago fuera del plazo establecido o a pedido del alumno');

INSERT INTO SOLICITUD_ESTADO
(NOMBRE,DESCRIPCION)
VALUES ('CANCELADA','Se ha realizado el pago por derecho a sustentacion de tesis');

INSERT INTO SOLICITUD_ESTADO
(NOMBRE,DESCRIPCION)
VALUES ('DESAPROBADA','La solicitud ha sido desaprobada por el Director de UPG');

INSERT INTO SOLICITUD_ESTADO
(NOMBRE,DESCRIPCION)
VALUES ('APROBADA','La solicitud ha sido aprobada por el Director de UPG');

INSERT INTO SOLICITUD_ESTADO
(NOMBRE,DESCRIPCION)
VALUES ('FINALIZADA','Se ha generado el horario para la sustentacion de tesis');

USE BD_TESIS;
INSERT INTO TESIS_TEMA
(NOMBRE)
VALUES ('Administraci�n industrial');
INSERT INTO TESIS_TEMA
(NOMBRE)
VALUES ('Planificaci�n');
INSERT INTO TESIS_TEMA
(NOMBRE)
VALUES ('Control de calidad');
INSERT INTO TESIS_TEMA
(NOMBRE)
VALUES ('Gestion de operaciones');
INSERT INTO TESIS_TEMA
(NOMBRE)
VALUES ('Proyecto de inversi�n');
INSERT INTO TESIS_TEMA
(NOMBRE)
VALUES ('Gesti�n y Dise�o de Experimentos');
INSERT INTO TESIS_TEMA
(NOMBRE)
VALUES ('Sistemas e Inform�tica');
INSERT INTO TESIS_TEMA
(NOMBRE)
VALUES ('Logistica');
INSERT INTO TESIS_TEMA
(NOMBRE)
VALUES ('Gestion empresarial');
INSERT INTO TESIS_TEMA
(NOMBRE)
VALUES ('Inteligencia Artificial');
INSERT INTO TESIS_TEMA
(NOMBRE)
VALUES ('Automatizaci�n');
INSERT INTO TESIS_TEMA
(NOMBRE)
VALUES ('Rob�tica en la industria');
INSERT INTO TESIS_TEMA
(NOMBRE)
VALUES ('Innovaci�n y administraci�n de la tecnolog�a');
INSERT INTO TESIS_TEMA
(NOMBRE)
VALUES ('Optimizaci�n de la producci�n');
INSERT INTO TESIS_TEMA
(NOMBRE)
VALUES ('Comercio Internacional');
INSERT INTO TESIS_TEMA
(NOMBRE)
VALUES ('Desarrollo sostenible');

INSERT INTO FORMA_PAGO
(NOMBRE)
VALUES ('EFECTIVO');
INSERT INTO FORMA_PAGO
(NOMBRE)
VALUES ('DEPOSITO A CUENTA CORRIENTE');


INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1300','Adolfo Oswaldo','Acevedo Borrego','Administraci�n','Ingenier�a Industrial','Dise�o y mejoramiento de servicios log�sticos','3858098','adolfo.acevedo@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1301','Ezzard Omar','Alvarez D�az','Ingenier�a de Sistemas','','Gesti�n empresarial.Sistemas e Inform�tica','3876182','ezzard.alvarez@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1302','Walter','And�a Valencia','Gesti�n Econ�mica Empresarial','','Proyectos de Inversi�n.Gesti�n de procesos industriales','7173274','walter.andia@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1303','Walter','Barrutia Feijoo','Ingenier�a de Procesos','Ingenier�a y Administraci�n de Operaciones','Innovaci�n y administraci�n de la tecnolog�a. Sistemas de manufactura. Modelo de Gesti�n de Empresas','8908098','walter.barrutia@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1304','Francisca','Bouby Tolentino','Econom�a: Pol�tica Econ�mica','Econom�a','Innovaci�n y administraci�n de la tecnolog�a. Gesti�n de Empresas','8908098','francisca.bouby@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1305','Orestes','Cachay Boza','Ingenier�a Industrial: Producci�n','Ingenier�a Industrial','Producci�n y Operaciones: Planeaci�n y control de la producci�n, estudios y an�lisis de log�stica. Dise�o y mejoramiento de servicios log�sticos.','2205277','orestes.cachay@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1306','Willy','Calsina Miramira','Gesti�n de Alta direcci�n','','Gesti�n de Alta direcci�n','7980133','willy.calsina@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1307','Juan Manuel','Cevallos Ampuero','Ingenier�a Industrial','Ingenier�a','Gesti�n Empresarial: Calidad, planeaci�n y control de la producci�n. Estrategias empresariales y procesos de negocios.','3025896','juan.cevallos@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1308','Alfonso Ram�n','Chung Pinz�s','Ingenier�a Industrial: Producci�n Industrial','Ingenier�a Industrial','Gesti�n Empresarial: Calidad, organizaci�n, costos, finanzas, medio ambiente. Prospectiva','3957745','alfonso.chung@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1309','Rosa Sumactika','Delgadillo Avila','Sistemas y Computaci�n','Ingenier�a de Producci�n','Gesti�n y producci�n empresarial: Optimizaci�n de la producci�n y gesti�n empresarial','7212732','rosa.delgadillo@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1310','Carlos Alfonso','Egusquiza Pereda','Econom�a Agr�cola','Ciencias Econ�micas y Comerciales','Ciencias Econ�micas, Econom�a Agr�cola','3835979','carlos.egusquiza@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1311','Jorge Jos�','Esponda Veliz','Ingenier�a Industrial: Producci�n','','Administraci�n y planificaci�n de Operaciones.Gerencia de Operaciones','5804902','jorge.esponda@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1312','Osiris','Feliciano Mu�oz','Ciencias: Proyectos de Inversi�n','','Proyectos de Inversi�n','8684157','osiris.feliciano@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1313','Teonila Doria','Garc�a Zapata','Administraci�n y Gesti�n P�blica','Ingenier�a Industrial','Producci�n y Operaciones: Planeaci�n y control de la producci�n. Gesti�n Empresarial: Calidad, organizaci�n. Estrategias empresariales y modelos de negocios','4419209','teonila.garcia@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1314','Hilmar Antonio','Hinojoza Lazo','Inform�tica','','Producci�n y Operaciones: Automatizaci�n, tecnolog�as limpias. Gesti�n Empresarial: Seguridad, medio ambiente. Estrategias empresariales y modelos de negocios','4781945','hilmar.hinojoza@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1315','Jorge Lu�s','Inche Mitma','Ingenier�a Qu�mica','Ciencias Administrativas','Sistemas de manufactura. Innovaci�n y administraci�n de la tecnolog�a. Modelos de Gesti�n Empresarial. Prospectiva','3032874','jorge.inche@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1316','Jorge Leonardo','Jave Nakayo','Ciencias con menci�n en Desarrollo Agrario Sostenible','Medio Ambiente y Desarrollo Sostenible','Medio ambiente y desarrollo sostenible.Gesti�n p�blica','7719130','jorge.jave@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1317','Ervwin','Kraenau Espinal','Estad�stica.Matem�tica','Ingenier�a Industrial','Construcci�n de �ndices, Indicadores, Instrumentos de Medici�n etc. Inteligencia Artificial, Automatizaci�n, Rob�tica, etc. en la industria.Planeamiento estrat�gico','6312141','ervwin.kraenau@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1318','David','Mauricio Sanchez','Matem�tica aplicada','Computaci�n','Matem�tica aplicada','6601300','david.mauricio@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1319','Daniel Humberto','Mavila Hinojosa','Construcci�n','','Gesti�n Empresarial: Organizaci�n, finanzas','6883554','daniel.mavila@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1320','Rosmeri Agustina','Mayta Huatuco','Ciencias con menci�n en Ingenier�a de Sistemas','','Gesti�n empresarial. Sistemas e Inform�tica','5219996','rosmeri.mayta@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1321','Fernando','Noriega Bardalez','Ingenier�a de Producci�n','','Gesti�n Empresarial: Finanzas.','5135210','fernando.noriega@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1322','Margarita','Pajares Flores','','','Metodolog�a de investigaci�n','5069068','margarita.pajares@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1323','Carlos','Quispe Atuncar','Ingenier�a Industrial con menci�n en Gesti�n de Operaciones y Productividad','','Administraci�n de Operaciones.Organizaci�n y administraci�n de Industrial','4487056','carlos.atuncar@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1324','Durga Edelmira','Ramirez Miranda','An�lisis y Gesti�n de la Ciencia y la Tecnolog�a','Ciencias Politicas y Sociolog�a','Innovaci�n y administraci�n de la tecnolog�a','3381341','durga.ramrez@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1325','Julio','Reyna Ramos','Ingenier�a Industrial: Gesti�n de Operaciones y Productividad','','Gesti�n de Operaciones','3393116','julio.reyna@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1326','Juan Manuel','Rivera Poma','Ingenier�a Industrial',NULL,'Gesti�n de empresas','7448808','juan.rivera@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1327','Edgar Cruz','Ruiz Lizama','Inform�tica','','Modelos y algoritmos de optimizaci�n de la producci�n, sistemas de producci�n','5682927','edgar.ruiz@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1328','Julio Alejandro','Salas Bacalla','Ingenier�a Industrial menci�n en gesti�n de Operaciones y Productividad','','Producci�n, distribuci�n de planta.Ergonom�a, productividad','7180634','julio.salas@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1329','Julio Cesar','Sandoval Inchaustegui','Administraci�n','','Desarrollo organizacional Planemiento estrat�gico, balanced scorecard.Gesti�n Estrat�gica.Comercio Internacional','6153703','julio.sandoval@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1330','Eulogio','Santos de la Cruz','Ciencia de Materiales','Ingenier�a Ambiental','Sistema de Manufactura.Sistema Ambiental','2073760','eulogio.santos@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1331','Nestor','Santos Jim�nez','','','Proyectos Industriales - Finanzas','3664315','nestor.santos@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1332','Oscar Rafael','Tinoco Gomez','Marketing Tur�stico y Hotelero','Medio Ambiente y Desarrollo Sostenible','Gesti�n y Dise�o de Experimentos Gesti�n de operaciones','7288207','oscar.rafael@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1333','Jorge Luis','Vergiu Canto','Gesti�n y Desarrollo: Gesti�n y Direcci�n de Empresas','','Log�stica y gesti�n de producci�n','5823979','jorge.vergiu@industrial.unmsm.pe',NULL);
INSERT INTO PROFESOR
(CODIGO,NOMBRES,APELLIDOS,MAESTRIA,DOCTORADO,OBSERVACIONES,TELEFONO,CORREO,URL_FOTO)
VALUES ('0A1334','German','Vergaray Ulfee','Administraci�n de la Educaci�n Universitaria','Ciencias Biol�gicas','','5425489','german.vergaray@industrial.unmsm.pe',NULL);



select *from SOLICITUD;
select *from PAGO_SOLICITUD;

exec OBTENER_TEMAS_POR_SOLICITUD 2