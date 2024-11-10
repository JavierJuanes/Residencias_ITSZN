namespace TECNM_Residencia
{
    internal class SQLiteConnection
    {
        private string connectionString;

        public SQLiteConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}