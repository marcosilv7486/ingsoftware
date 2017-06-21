using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using Data;
using System.Data.SqlClient;
namespace Negocio
{
    public class GestionTesis : IGestionTesis
    {

        private IAlumnoRepository alumnoRepository;
        
        public List<Alumno> obtenerAlumnosHabilitados()
        {
            SqlConnection cn=null;
            List<Alumno> data = new List<Alumno>();
            try
            {
                cn = HelperDB.GetSqlConnection();
                data = alumnoRepository.obtenerHabilitados(cn).ToList<Alumno>();;
            }
            catch (Exception e)
            {
                
            }
            finally
            {
                if (cn != null) 
                {
                    cn.Close();
                    cn.Dispose();
                }
            }
            return data;
        }
    }
}
