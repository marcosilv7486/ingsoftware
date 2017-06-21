using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Dominio;
namespace Data
{
    public class AlumnoRepository : IAlumnoRepository
    {
        public ICollection<Dominio.Alumno> obtenerHabilitados(System.Data.SqlClient.SqlConnection conexion)
        {
            String nombreProcedure = "OBTENER_ALUMNOS_HABILITADOS";
            SqlCommand comando = new SqlCommand(nombreProcedure, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader lector = comando.ExecuteReader();
            List<Alumno> data = mapearListaAlummnos(lector);
            lector.Close();
            lector.Dispose();
            comando.Dispose();
            return data;
        }

        private List<Alumno> mapearListaAlummnos(SqlDataReader lector)
        {
            List<Alumno> data = new List<Alumno>();
            while (lector.HasRows)
            {
                Alumno alumno = new Alumno();
                alumno.id = int.Parse(lector["ID"].ToString());
                alumno.nombre = lector["NOMBRES"].ToString();
                alumno.apellidos = lector["APELLIDOS"].ToString();
                alumno.correo = lector["CORREO"].ToString();
                alumno.tipoDocumento = lector["TIPO_DOCUMENTO"].ToString();
                alumno.numeroDocumento = lector["NUMERO_DOCUMENTO"].ToString();
                alumno.planCurricular = lector["PLAN_CURRICULAR"].ToString();
                alumno.programaPostGrado.nombrePrograma = lector["NOMBRE_PROGRAMA"].ToString();
                alumno.urlFoto = lector["URL_FOTO"].ToString();
                data.Add(alumno);
            }
            return data;
        }

        private Alumno mapearAlumno(SqlDataReader lector)
        {
            Alumno alumno = new Alumno();
            while (lector.HasRows)
            {
                alumno.id = int.Parse(lector["ID"].ToString());
                alumno.nombre = lector["NOMBRES"].ToString();
                alumno.apellidos = lector["APELLIDOS"].ToString();
                alumno.correo = lector["CORREO"].ToString();
                alumno.tipoDocumento = lector["TIPO_DOCUMENTO"].ToString();
                alumno.numeroDocumento = lector["NUMERO_DOCUMENTO"].ToString();
                alumno.planCurricular = lector["PLAN_CURRICULAR"].ToString();
                alumno.programaPostGrado.nombrePrograma = lector["NOMBRE_PROGRAMA"].ToString();
                alumno.urlFoto = lector["URL_FOTO"].ToString();
                break;
            }
            return alumno;
        }

        public ICollection<Dominio.Alumno> obtenerTodos(System.Data.SqlClient.SqlConnection conexion)
        {
           String nombreProcedure = "OBTENER_ALUMNOS_TODOS";
            SqlCommand comando = new SqlCommand(nombreProcedure, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader lector = comando.ExecuteReader();
            List<Alumno> data = mapearListaAlummnos(lector);
            lector.Close();
            lector.Dispose();
            comando.Dispose();
            return data;
        }
       


        public Alumno buscarPorId(int id, SqlConnection conexion)
        {
            throw new NotImplementedException();
        }

        public Alumno buscarPorCodigo(string codigo, SqlConnection conexion)
        {
            throw new NotImplementedException();
        }
    }
}
