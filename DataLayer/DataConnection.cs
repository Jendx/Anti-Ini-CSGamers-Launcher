using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace AntiIniUI.DataLayer
{
    
    public class DataConnection
    {
        private SqlConnection m_Connection;
        private static readonly Object m_LockObj = new object();
        private static DataConnection m_Instance = null;
        private static readonly String SQL_SELECT = "SELECT * FROM Servers ";

        public SqlConnection Connection
        {
            get => m_Connection;
            set => m_Connection = value;
        }

        public static DataConnection Instance
        {
            get
            {
                lock (m_LockObj)
                {
                    return m_Instance ?? (m_Instance = new DataConnection());
                }
            }
        }

        public bool Connect()
        {
            if(Connection.State != System.Data.ConnectionState.Open)
            {
                Connection.ConnectionString = "server=dbsys.cs.vsb.cz\\STUDENT;database=bar0642;user=bar0642;password=VmRxXVwQCy";
                Connection.Open();
            }
            return true;
        }

        public SqlCommand CreateCommand(string strCommand)
        {
            SqlCommand command = new SqlCommand(strCommand, Connection);

            return command;
        }

        public SqlDataReader Select(SqlCommand command)
        {
            SqlDataReader sqlReader = command.ExecuteReader();
            return sqlReader;
        }

        public void Close()
        {
            Connection.Close();
        }

        /// DATA Management

        public static Collection<Server> GetServers(DataConnection pDb = null)
        {
            DataConnection db;
            if (pDb == null)
            {
                db = new DataConnection();
                db.Connect();
            }
            else
            {
                db = (DataConnection)pDb;
            }

            SqlCommand command = db.CreateCommand(SQL_SELECT);
            SqlDataReader reader = db.Select(command);

            var data = Read(reader);


            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return data;
        }

        private static Collection<Server> Read(SqlDataReader reader) // Reader
        {
            Collection<Server> users = new Collection<Server>();

            while (reader.Read())
            {
                int i = -1;
                Server user = new Server();
                user.Server_id = reader.GetInt32(++i);
                user.ServerName = reader.GetString(++i);
                user.ConnectionArgument = reader.GetString(++i);

                users.Add(user);
            }
            return users;
        }
    }
}
