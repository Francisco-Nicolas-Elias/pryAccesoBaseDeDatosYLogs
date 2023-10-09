using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace pryAccesoBaseDeDatosYLogs
{
   
    internal class clsAccesoDatos
    {
        //declaro objeto conexionBD de la clase OleDBConecction
        OleDbConnection conexionBD;

        public void ConexionABase()
        {
            try
            {
                conexionBD = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=D:\\Escritorio\\pryAccesoBaseDeDatosYLogs\\pryAccesoBaseDeDatosYLogs\\Resources\\Datos login.accdb");
                //conexionBD = new OleDbConnection("@Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:D:\\Escritorio\\pryAccesoBaseDeDatosYLogs\\pryAccesoBaseDeDatosYLogs\\Resources\\Datos login.accdb");
                conexionBD.Open();
            }
            catch(Exception ex) //ex variable de excecpción
            {
                MessageBox.Show(ex.Message);
            }


            //conexionBD = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:D:\\Escritorio\\pryAccesoBaseDeDatosYLogs\\pryAccesoBaseDeDatosYLogs\\Resources\\Datos login.accdb");
            //conexionBD.Open();
            

            //Cree una función llamada ConexionABAse para llamarla en los procedimientos luego
        }
            
    }
}
