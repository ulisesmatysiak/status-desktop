using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class DailyNegocio
    {
        public List<Daily> listar()
        {
            List<Daily> lista = new List<Daily>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id, Fecha, Score, Words, Helped from DAILY");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Daily aux = new Daily();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Score = (int)datos.Lector["Score"];
                    aux.Words = (string)datos.Lector["Words"];
                    aux.Helped = (bool)datos.Lector["Helped"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
