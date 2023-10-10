using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;



namespace pryAccesoBaseDeDatosYLogs
{
   
    internal class clsAccesoDatos
    {
        //declaro objeto conexionBD de la clase OleDBConecction
        OleDbConnection conexionBaseD = new OleDbConnection();
        OleDbCommand objComando = new OleDbCommand();
        OleDbDataReader objdReader;

        public void ConexionABase()
        {
            try
            {
                 string conexionBD = (@"Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=..\\..\\Resources\\Datos login.accdb");
                // asignar la cadena al objeto conexión
                conexionBaseD.ConnectionString = conexionBD;
                // abrir la conexión con la base de datos
                conexionBaseD.Open();
                // establecer las propiedades al objeto comando
                objComando.Connection = conexionBaseD;
                objComando.CommandType = CommandType.TableDirect;
                objComando.CommandText = "Usuarios"; // nombrede la tabla a leer
                // ejecutar la lectura de la tabla con un objetoDataReader
                objdReader = objComando.ExecuteReader();
                // controlar si la lectura obtuvo registros
                if (objdReader.HasRows)
                {
                    string datos = ""; // variable auxiliarpara almacenar los datos de la tabla
                    while (objdReader.Read()) // leer mientras existanregistros
                    {
                        // concatenar los campos de la tabla'Usuario': 'ID' y
                        // 'Usuario' la contraseña no la muestra

                        // para leer cada campo hay que especificarel tipo de dato y
                        // la posición del campo en la tabla

                        // en este caso el primer campo (posisicón0) es de tipo entero y
                        // el segundo campo (posición 1) es string
                        datos += objdReader.GetInt32(0).ToString() + ", " + objdReader.GetString(1) + "\r\n";
                    }
                    // mostrar todos los datos obtenidos dela tabla
                    MessageBox.Show(datos, "Tabla de Uuarios– DataReader");
                }
                // cerrar la conexión
                conexionBaseD.Close();
            }
            catch (Exception ex) //ex variable de excecpción
            {
                MessageBox.Show(ex.Message);
            }

             //Cree una función llamada ConexionABAse para llamarla en los procedimientos luego
        }
            
    }
}
