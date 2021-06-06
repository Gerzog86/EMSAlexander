using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EMSAlexander
{
    public class Employee
    {

        private string _barcode;
        private string _lastname;
        private string _firstname;
        private string _middlename;
        private string _organisation;
        private string _connectionstring;
        private Schedule[] _worktimes;

        public Employee()
        { 
        }
        public Employee(string barcode, string connectionstring)
        {
            _barcode = barcode;
            _connectionstring = connectionstring;
            LoadInfo();
        }
        public Employee (string barcode, string lastname, string firstname, string middlename, string organisation, Schedule[] worktimes, string connectionstring)
        {
            _barcode = barcode;
            _lastname = lastname;
            _firstname = firstname;
            _middlename = middlename;
            _organisation = organisation;
            _worktimes = worktimes;
            _connectionstring = connectionstring;
            UpdateField();
        }

        protected void LoadInfo()
        {

            // получение основных данных

            SqlConnection _connector = new SqlConnection(_connectionstring);
            SqlCommand _command = new SqlCommand();

            _connector.Open();

            SqlTransaction _transaction = _connector.BeginTransaction();

            _command.Connection = _connector;
            _command.Transaction = _transaction;

            _command.CommandText = $"SELECT lastname FROM personnel WHERE barcode = {_barcode}";
            object result = _command.ExecuteScalar();
            _lastname = result.ToString();

            _command.CommandText = $"SELECT firstname FROM personnel WHERE barcode = {_barcode}";
            result = _command.ExecuteScalar();
            _firstname = result.ToString();

            _command.CommandText = $"SELECT middlename FROM personnel WHERE barcode = {_barcode}";
            result = _command.ExecuteScalar();
            _middlename = result.ToString();

            _command.CommandText = $"SELECT organisation FROM personnel WHERE barcode = {_barcode}";
            result = _command.ExecuteScalar();
            _organisation = result.ToString();

            


            //получение графика работы

            _command.CommandText = $"SELECT COUNT(dayofweek) FROM schedule WHERE barcode = {_barcode}";
            int res = Int32.Parse(_command.ExecuteScalar().ToString());
            Schedule[] worktimes = new Schedule[res];

            _command.CommandText = $"SELECT dayofweek, intime, outtime FROM schedule WHERE barcode = {_barcode}";
            SqlDataReader wtresult = _command.ExecuteReader();

            if (wtresult.HasRows)
            {
                for (int i = 0; i < res; i++)
                {
                    wtresult.Read();
                    worktimes[i] = new Schedule(wtresult.GetInt32(0), wtresult.GetString(1), wtresult.GetString(2));
                }
            }
            _worktimes = worktimes;

            _connector.Close();
        }
        public void UpdateField ()
        {
            SqlConnection _connector = new SqlConnection(_connectionstring);
            SqlCommand _command = new SqlCommand();

            _connector.Open();

            SqlTransaction _transaction = _connector.BeginTransaction();

            _command.Connection = _connector;
            _command.Transaction = _transaction;

            _command.CommandText = $"SELECT barcode FROM personnel WHERE barcode = {_barcode}";
            object result = _command.ExecuteScalar();
            if  (result is null)
            {
                _command.CommandText = $"INSERT INTO personnel (barcode, lastname, firstname, middlename, organisation) VALUES ('{_barcode}','{_lastname}','{_firstname}','{_middlename}','{_organisation}')";
            }
            else
            {
                _command.CommandText = $"UPDATE personnel SET lastname = '{_lastname}', firstname = '{_firstname}', middlename = '{_middlename}', organisation = '{_organisation}' WHERE barcode = '{_barcode}'";
            }
            _command.ExecuteNonQuery();
            //_transaction.Commit();

            _command.CommandText = $"DELETE FROM schedule WHERE barcode = '{_barcode}'";
            _command.ExecuteNonQuery();
            //_transaction.Commit();

            foreach (Schedule i in _worktimes)
            {
                _command.CommandText = $"INSERT INTO schedule (barcode, dayofweek, intime, outtime) VALUES ('{_barcode}','{i._day}','{i._intime}','{i._outtime}')";
                _command.ExecuteNonQuery();
                //_transaction.Commit();
            }
            _transaction.Commit();
            _connector.Close();
        }

        public string GetLastName ()
        {
            return _lastname;
        }
        public void SetLastName (string lastname)
        {
            _lastname = lastname;
        }
        public string GetFirstName()
        {
            return _firstname;
        }
        public void SetFirstName(string firstname)
        {
            _firstname = firstname;
        }
        public string GetMiddleName()
        {
            return _middlename;
        }
        public void SetMiddleName(string middlename)
        {
            _middlename = middlename;
        }
        public string GetOrganisation()
        {
            return _organisation;
        }
        public void SetOrganisation(string organisation)
        {
            _organisation = organisation;
        }


        public Schedule[] GetWorkTimes()
        {
            return _worktimes;
        }

        public void SetWorkTimes(Schedule[] workTimes)
        {
            _worktimes = workTimes;
        }
    }
}
