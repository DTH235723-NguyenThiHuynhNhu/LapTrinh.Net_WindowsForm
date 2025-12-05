using MySql.Data.MySqlClient;

namespace QuanLyNhanVien
{
    internal class KetNoi
    {
        private MySqlConnection connection;
        private string connectionString =
            "server=localhost;database=qlnv;uid=root;pwd=Nhu15011507@;";

        public KetNoi()
        {
            connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
