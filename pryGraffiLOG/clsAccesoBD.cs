using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace pryGraffiLOG
{
    internal class clsAccesoBD
    {
      
            public string EstadoConexion;

            OleDbConnection conexionBD;
            string rutaArchivo;
            OleDbCommand comandoBD;
            OleDbDataReader lectorBD;

            public void ConectarBaseDatos()
            {
                try
                {
                    rutaArchivo = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ../../Base/LOG.accdb";

                    conexionBD = new OleDbConnection();

                    conexionBD.ConnectionString = rutaArchivo;

                    conexionBD.Open();

                    EstadoConexion = "Conectado a la base " +conexionBD.DataSource;
                }
                catch (Exception exepcion)
                {
                    EstadoConexion = "Error en la conexión." + exepcion.Message;
                }

            }

        public void TraerDatos(DataGridView grilla)
            {
            try
            {
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Registros";

                lectorBD = comandoBD.ExecuteReader();

                grilla.Columns.Add("Categoría", "Categoría");
                grilla.Columns.Add("Fecha/Hora", "Fecha/Hora");
                grilla.Columns.Add("Descripción", "Descripción");

                while (lectorBD.Read())
                {
                    //DatosExtraidos += lectorBD[7] + "\n";
                    grilla.Rows.Add(lectorBD[1], lectorBD[2], lectorBD[7]);

                }
            }
            catch (Exception Errores)
            {
                EstadoConexion = Errores.Message;
            }

        }


    }

        
    }

