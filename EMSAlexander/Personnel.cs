using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EMSAlexander
{
    public static class Personnel
    {
        private static string _connectionstring;
        public static Dictionary<string, Employee> _personnel;

        public static void Initialize(string connectionstring)
        {
            _personnel = new Dictionary<string, Employee>();
            _connectionstring = connectionstring;
            SqlConnection _connector = new SqlConnection(_connectionstring);
            SqlCommand _command = new SqlCommand();

            _connector.Open();

            SqlTransaction _transaction = _connector.BeginTransaction();

            _command.Connection = _connector;
            _command.Transaction = _transaction;

            _command.CommandText = "SELECT barcode FROM personnel";
            SqlDataReader result = _command.ExecuteReader();

            

            if (result.HasRows)
            {
                while (result.Read())
                {
                    _personnel.Add(result.GetString(0), new Employee(result.GetString(0), _connectionstring));
                }
            }
            _connector.Close();
        }

        public static bool TryAddField (string barcode, string lastname, string firstname, string middlename, string organisation, Schedule[] worktimes)
        {
            try
            {
                Employee newEmployee = new Employee(barcode, lastname, firstname, middlename, organisation, worktimes, _connectionstring);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            Initialize(_connectionstring);
            return true;
        }
    }
}
