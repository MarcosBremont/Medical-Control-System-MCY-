using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Medical_Control_System__MCY_.Clases
{
    public class Conexion
    {
        //Cadena de Conexion
        string cadena = ("Server=localhost; database=medicalcontrolsystemmcs; user=root; password=1234");

        public MySqlConnection ConectarDB = new MySqlConnection();

        //Constructor

        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                ConectarDB.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD "+ ex.Message);
            }
        }

        //Metodo para cerrar la conexion
        public void cerrar()
        {
            ConectarDB.Close();
        }
    }
}
