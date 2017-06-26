using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using System.Data.SqlClient;
namespace Data
{
    public class ProfesorRepository : IProfesorRepository
    {

        public List<Profesor> obtenerHabilitados(SqlConnection conexion)
        {
            String sql = "select *from profesor where eliminado=0 order by codigo asc";
            SqlCommand comando = new SqlCommand(sql, conexion);
            SqlDataReader lector = comando.ExecuteReader();
            List<Profesor> data = new List<Profesor>();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Profesor profesor = new Profesor();
                    profesor.id = int.Parse(lector["ID"].ToString());
                    profesor.nombres = lector["NOMBRES"].ToString();
                    profesor.codigo = lector["CODIGO"].ToString();
                    profesor.apellidos = lector["APELLIDOS"].ToString();
                    if (!lector.IsDBNull(4))
                    {
                        profesor.maestria = lector["MAESTRIA"].ToString();
                    }
                    profesor.observaciones = lector["OBSERVACIONES"].ToString();
                    profesor.telefono = lector["TELEFONO"].ToString();
                    profesor.correo = lector["CORREO"].ToString();
                    if (!lector.IsDBNull(5))
                    {
                        profesor.doctorado = lector["DOCTORADO"].ToString();
                    }
                    data.Add(profesor);
                }
            }
            lector.Close();
            lector.Dispose();
            comando.Dispose();
            return data;
        }
    }
}
