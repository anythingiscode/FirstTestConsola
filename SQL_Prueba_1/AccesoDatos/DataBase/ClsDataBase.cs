using System;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos.DataBase
{
    public class ClsDataBase    //Cambio "internal" por "public" así la "LogicaDeNegosios" Podra acceder a los métodos de esta clase
    {
        //División en apartados de información: #region+TAB+TAB
        #region Variables Privadas

        //Variables para conectarnos a la BDD
        private SqlConnection _objSqlConnection;        //Las variables privadas empiezan por "_" + minuscula
        private SqlDataAdapter _objSqlDataAdapter;      //Forma para enviar una demanda a la BDD --> Lectura   (hace los select)
        private SqlCommand _objSqlCommand;              //Forma para enviar una demanda a la BDD --> Crear, actualizar y borrar
        private DataSet _dsResultados;                  //ds: data set
        private DataTable _dtParametros;                //dt: data Table -- La tabla con los parametros para "SqlDataAdapter" y "SqlCommand"

        private string _nombreTabla, _nombreSP, _mensajeErrorDB, _valorEscalar, nombreBD;    // SP: store procedure  -- _valorEscalar: valores de la consulta

        private bool _scalar;                 // Cuando sea "true" recivoo escalar, "false" no recibo escalar sino una tabla

        #endregion

        #region Variables Públicas

        //Proceso de encapsulado:

        public SqlConnection ObjSqlConnection { get => _objSqlConnection; set => _objSqlConnection = value; }
        public SqlDataAdapter ObjSqlDataAdapter { get => _objSqlDataAdapter; set => _objSqlDataAdapter = value; }
        public SqlCommand ObjSqlCommand { get => _objSqlCommand; set => _objSqlCommand = value; }
        public DataSet DsResultados { get => _dsResultados; set => _dsResultados = value; }
        public DataTable DtParametros { get => _dtParametros; set => _dtParametros = value; }
        public string NombreTabla { get => _nombreTabla; set => _nombreTabla = value; }
        public string NombreSP { get => _nombreSP; set => _nombreSP = value; }
        public string MensajeErrorDB { get => _mensajeErrorDB; set => _mensajeErrorDB = value; }
        public string ValorEscalar { get => _valorEscalar; set => _valorEscalar = value; }
        public string NombreBD { get => nombreBD; set => nombreBD = value; }
        public bool Scalar { get => _scalar; set => _scalar = value; }

        #endregion

        #region Constructores

        // Inicialización de los atributos
        public ClsDataBase()
        {
            DtParametros = new DataTable("SpParametros");
            DtParametros.Columns.Add("Nombre");
            DtParametros.Columns.Add("TipoDeDato");
            DtParametros.Columns.Add("Valor");

            NombreBD = string.Empty;            // Podemos incializar como "Empty". (Para el programa usaremos el nombre de la BDD creada que es "DB_BasePruebas"
            NombreBD = "DB_BasePruebas";
        }
        #endregion

        #region Métodos Privados

        private void CrearConexionBDD(ref ClsDataBase ObjDataBase)
        {
            switch (ObjDataBase.NombreBD)
            {
                case "DB_BasePruebas":
                    // Creo la cadena de datos de conexion para mi BDD
                    ObjDataBase.ObjSqlConnection = new SqlConnection(Properties.Settings.Default.cadenaConexion_DB_BasePruebas); // Ponemos los datos de conexión
                    /* Proceso para crear la conexión:
                        1 Click drcho en AccesoDatos
                        2 Propiedades
                        3 Rellenar los datos : Nombre - Tipo - Ámbito  - Valor (click en los "..."
                    más detalles min 31 del video parte 2 de SQL
                    */
                    break;
                case "BaseDatos2":              //Si hubieran más BDD
                    break;
            }
        }
        private void ValidarConexionBDD(ref ClsDataBase ObjDataBase)
        {
            // Si esta abierta que la abra y si esta cerrada que la cierre y la quite de memoria
            if(ObjDataBase.ObjSqlConnection.State == ConnectionState.Closed)
            {
                ObjDataBase.ObjSqlConnection.Open();    
            }
            else
            {
                ObjDataBase.ObjSqlConnection.Close();
                ObjDataBase.ObjSqlConnection.Dispose();     //Dispose, lo quita de memoria
            }
        }
        private void AgregarParametrosBDD(ref ClsDataBase ObjDataBase)
        {
            if(ObjDataBase.DtParametros != null)
            {
                SqlDbType TipoDatoSQL = new SqlDbType();

                foreach(DataRow item in ObjDataBase.DtParametros.Rows)
                {
                    switch (item[1])        //La columa 1 es la de : DtParametros.Columns.Add("TipoDeDato"); declarada antes
                    {
                        case "1":
                            TipoDatoSQL = SqlDbType.Bit;    //Es un booleno
                            break;
                        case "2":
                            TipoDatoSQL = SqlDbType.TinyInt;    //Es un booleno
                            break;
                        case "3":
                            TipoDatoSQL = SqlDbType.SmallInt;    //Es un booleno
                            break;
                        case "4":
                            TipoDatoSQL = SqlDbType.Int;    //Es un booleno
                            break;
                        case "5":
                            TipoDatoSQL = SqlDbType.BigInt;    //Es un booleno
                            break;
                        case "6":
                            TipoDatoSQL = SqlDbType.Decimal;    //Es un booleno
                            break;
                        case "7":
                            TipoDatoSQL = SqlDbType.SmallMoney;    //Es un booleno
                            break;
                        case "8":
                            TipoDatoSQL = SqlDbType.Money;    //Es un booleno
                            break;
                        case "9":
                            TipoDatoSQL = SqlDbType.Float;    //Es un booleno
                            break;
                        case "10":
                            TipoDatoSQL = SqlDbType.Real;    //Es un booleno
                            break;
                        case "11":
                            TipoDatoSQL = SqlDbType.Date;    //Es un booleno
                            break;
                        case "12":
                            TipoDatoSQL = SqlDbType.Time;    //Es un booleno
                            break;
                        case "13":
                            TipoDatoSQL = SqlDbType.SmallDateTime;    //Es un booleno
                            break;
                        case "14":
                            TipoDatoSQL = SqlDbType.Char;    //Es un booleno
                            break;
                        case "15":
                            TipoDatoSQL = SqlDbType.NChar;    //Es un booleno
                            break;
                        case "16":
                            TipoDatoSQL = SqlDbType.NVarChar;    //Es un booleno
                            break;
 
                        default:
                            break;
                    }
                    if (ObjDataBase.Scalar)
                    {
                        if (item[2].ToString().Equals(string.Empty))
                        {
                            ObjDataBase.ObjSqlCommand.Parameters.Add(item[0].ToString(), TipoDatoSQL).Value = DBNull.Value;
                        }
                        else
                        {
                            ObjDataBase.ObjSqlCommand.Parameters.Add(item[0].ToString(), TipoDatoSQL).Value = item[2].ToString();
                        }
                    }
                    else
                    {
                        if (item[2].ToString().Equals(string.Empty))
                        {
                            ObjDataBase.ObjSqlDataAdapter.SelectCommand.Parameters.Add(item[0].ToString(), TipoDatoSQL).Value = DBNull.Value;
                        }
                        else
                        {
                            ObjDataBase.ObjSqlDataAdapter.SelectCommand.Parameters.Add(item[0].ToString(), TipoDatoSQL).Value = item[2].ToString();
                        }
                    }
                }
            }
        }
        private void PrepararConexionBDD(ref ClsDataBase ObjDataBase)
        {
            CrearConexionBDD(ref ObjDataBase);
            ValidarConexionBDD(ref ObjDataBase);
        }
        private void EjecutarDataAdapter(ref ClsDataBase ObjDataBase)
        {
            try
            {
                PrepararConexionBDD(ref ObjDataBase);

                ObjDataBase.ObjSqlDataAdapter = new SqlDataAdapter(ObjDataBase.NombreSP, ObjDataBase._objSqlConnection);
                ObjDataBase.ObjSqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                AgregarParametrosBDD(ref ObjDataBase);
                ObjDataBase.DsResultados = new DataSet();
                ObjDataBase.ObjSqlDataAdapter.Fill(ObjDataBase.DsResultados, ObjDataBase.NombreTabla);
            }
            catch (Exception ex)
            {
                ObjDataBase.MensajeErrorDB = ex.Message.ToString();
            }
            finally
            {
                if (ObjDataBase.ObjSqlConnection.State == ConnectionState.Open)
                {
                    ValidarConexionBDD(ref ObjDataBase);
                }
            }
        }
        private void EjecutarCommand(ref ClsDataBase ObjDataBase)
        {
            try
            {
                PrepararConexionBDD(ref ObjDataBase);
                ObjDataBase.ObjSqlCommand = new SqlCommand(ObjDataBase.NombreSP, ObjDataBase._objSqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                AgregarParametrosBDD(ref ObjDataBase);
                if (ObjDataBase.Scalar)         //Si es true
                {
                    ObjDataBase.ValorEscalar = ObjDataBase.ObjSqlCommand.ExecuteScalar().ToString().Trim();
                }
                else
                {
                    ObjDataBase.ObjSqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                ObjDataBase.MensajeErrorDB = ex.Message.ToString();
            }
            finally
            {
                if (ObjDataBase.ObjSqlConnection.State == ConnectionState.Open)
                {
                    ValidarConexionBDD(ref ObjDataBase);
                }
            }
        }
        #endregion

        #region Métodos Públcos

        public void CRUD(ref ClsDataBase ObjDataBase)
        {
            if (ObjDataBase.Scalar)
            {
                EjecutarCommand(ref ObjDataBase);
            }
            else
            {
                EjecutarDataAdapter(ref ObjDataBase);
            }
        }
        #endregion

    }
}

