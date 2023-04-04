using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace proyecto_Topicos
{
    internal class sqlClass
    {

        private MySqlConnection conDB;
        private MySqlConnectionStringBuilder connectSt = new MySqlConnectionStringBuilder();

        public sqlClass(string server, string username, string pass, string DB)
        {
            configConnectionString(server, username, pass, DB);
            initMySqlService();
        }

        ~sqlClass()
        {
            conDB.Close();
        }

        private void initMySqlService()
        {
            conDB = new MySqlConnection(connectionString: this.connectSt.ToString());
        }

        public object SqlQuery(string query)
        {
            object resultado = null;
            try
            {
                conDB.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show("No se ha podido establecer conexión con el servidor.");
            }
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, this.conDB);
                resultado = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

            }
            conDB.Close();
            return resultado;
        }

        public int SqlQuery(string query, string keyword0, bool isInt)
        {
            int temp = 0;
            conDB.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, this.conDB);
                MySqlDataReader temp1 = cmd.ExecuteReader();
                if (temp1.Read())
                {
                    temp = (int.Parse(temp1[keyword0].ToString()));
                }
                //              
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            conDB.Close();
            return temp;
        }

        public string SqlQuery(string query, string keyword0, string isStr)
        {
            string temp = "";
            conDB.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, this.conDB);
                MySqlDataReader temp1 = cmd.ExecuteReader();
                temp1.Read();
                temp = temp1[keyword0].ToString();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            conDB.Close();
            return temp;
        }

        public List<string> SqlQuery(string query, string keyword0)
        {
            List<string> temp = new List<string>();
            conDB.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, this.conDB);
                MySqlDataReader temp1 = cmd.ExecuteReader();

                while (temp1.Read())
                {
                    temp.Add(temp1[keyword0].ToString());
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            conDB.Close();
            return temp;
        }

        public List<int> SqlQuery(string query, string keyword0, int isInt)
        {
            List<int> temp = new List<int>();
            conDB.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, this.conDB);
                MySqlDataReader temp1 = cmd.ExecuteReader();

                while (temp1.Read())
                {
                    temp.Add(int.Parse(temp1[keyword0].ToString()));
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            conDB.Close();
            return temp;
        }

        public bool insertData(string query)
        {
            try
            {
                conDB.Open();
            }
            catch(Exception)
            {

            }
            
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conDB);
                cmd.ExecuteNonQuery();
                conDB.Close();
                return true;
            }
            catch (Exception ex)
            {
            }
            conDB.Close();
            return false;
        }

        public bool deleteData(string query)
        {
            bool res = false;

            conDB.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conDB);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                conDB.Close();
                res = true;
                
            }catch(Exception x)
            {

            }
            conDB.Close();
            return res;
        }

        public System.Data.DataSet sqlQueryGridView(string query)
        {

            MySqlCommand cmd = new MySqlCommand(query, conDB);
            MySqlDataAdapter mDatos = new MySqlDataAdapter(cmd);
            System.Data.DataSet ds = new System.Data.DataSet();

            mDatos.Fill(ds);

            return ds;
        }
        private void configConnectionString(string server, string username, string pass, string DB)
        {
            connectSt.Server = server;
            connectSt.UserID = username;
            connectSt.Password = pass;
            connectSt.Database = DB;
        }

    }
}
