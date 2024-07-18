using MySql.Data.MySqlClient;

namespace Location_photocopieur.Data
{
    internal class Database
    {
        private readonly string _server = "127.0.0.1";
        private readonly string _uid = "root";
        private readonly string _password = "";
        private readonly string _database="challenge";
        private MySqlConnection _connection;
        public MySqlConnection Connection { get => _connection; }
        
        public Database()
        {
            InitConnection();
        }

        private void InitConnection()
        {
            string connectionString = $"server={_server};uid={_uid};pwd={_password};database={_database}";
            _connection = new MySqlConnection(connectionString);
        }

        public void DropTable(string tableName)
        {
            string dropTable = $"DROP TABLE {tableName}";
            try
            {
                Connection.Open();
                MySqlCommand cmd = new MySqlCommand(dropTable, Connection);
                int i = cmd.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Source+ " : " +ex.Message);
            }
        }

        public void CreateTableClient()
        {
            try
            {
                string createTable = "CREATE TABLE Client ( id_client INT PRIMARY KEY NOT NULL AUTO_INCREMENT, nom VARCHAR(70), prenom VARCHAR(70), n_adresse INT, rue_adresse TEXT, ville VARCHAR(60), n_telephone VARCHAR(20) )";
                Connection.Open();
                MySqlCommand cmd = new MySqlCommand(createTable, Connection);
                int i = cmd.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Source + " : " + ex.Message);
            }
        }
        public void CreateTablePhotocopieur()
        {
            try
            {
                string createTable = "CREATE TABLE Photocopieur ( id_photocopieur INT PRIMARY KEY NOT NULL AUTO_INCREMENT, model VARCHAR(200), annee_construction INT )";
                Connection.Open();
                MySqlCommand cmd = new MySqlCommand(createTable, Connection);
                int i = cmd.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Source + " : " + ex.Message);
            }
        }
        public void CreateTableTechnicien()
        {
            try
            {
                string createTable = "CREATE TABLE Technicien ( id_technicien INT PRIMARY KEY NOT NULL AUTO_INCREMENT, nom VARCHAR(70), prenom VARCHAR(70), ville_activite VARCHAR(60), n_telephone VARCHAR(20) )";
                Connection.Open();
                MySqlCommand cmd = new MySqlCommand(createTable, Connection);
                int i = cmd.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Source + " : " + ex.Message);
            }
        }
    }
}
