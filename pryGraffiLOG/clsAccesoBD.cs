using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace pryGraffiLOG
{
    internal class clsAccesoBD
    {
      
            public string EstadoConexion;

            OleDbConnection conexionBD;
            string rutaArchivo;
            OleDbCommand comandoBD;
            OleDbDataReader lectorBD;
        private OleDbDataAdapter adaptadorDS;
        private DataTable objDataSet;

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
        public void TraerDatosDataSet(DataGridView grilla)
        {
            try
            {
                ConectarBaseDatos();
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Registros";

                adaptadorDS = new OleDbDataAdapter(comandoBD);
                adaptadorDS.Fill(objDataSet, "Registros");

                //if (objDataSet.Tables["Registros"].Rows.Count > 0)
                //{
                //    grilla.Columns.Add("ID", "ID");
                //    grilla.Columns.Add("Categoría", "Categoría");
                //    grilla.Columns.Add("Fecha/Hora", "Fecha/Hora");
                //    grilla.Columns.Add("Descrip", "Apellido");

                //    foreach (DataRow fila in objDataSet.Tables[0].Rows)
                //    {
                //        //DatosExtraidos += fila[1] + "\n";

                //        grilla.Rows.Add(fila[0], fila[1], fila[2]);
                //    }

                    

                //}

            }
            catch (Exception)
            {

                throw;
            }


        }

    }

        
    }

