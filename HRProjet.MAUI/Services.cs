

using HRProjet.MAUI.MVVM.Models;
using SQLite;

namespace HRProjet.MAUI
{
    public class EmployeeDbSerivce
    {
        SQLiteConnection conn;
        string _dbPath;
        public string StatusMessage;
        int result = 0;
        public EmployeeDbSerivce(string dbPath)
        {
            _dbPath = dbPath;
        }

        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Employee>();
        }

        public List<Employee> GetEmployees()
        {
            try
            {
                Init();
                return conn.Table<Employee>().ToList();
            }
            catch (Exception)
            {
                StatusMessage = "Failed to retrieve data.";
            }

            return new List<Employee>();
        }

        public Employee GetEmployee(int id)
        {
            try
            {
                Init();
                return conn.Table<Employee>().FirstOrDefault(q => q.Id == id);
            }
            catch (Exception)
            {
                StatusMessage = "Failed to retrieve data.";
            }

            return null;
        }

        public int DeleteEmployee(int id)
        {
            try
            {
                Init();
                return conn.Table<Employee>().Delete(q => q.Id == id);
            }
            catch (Exception)
            {
                StatusMessage = "Failed to delete data.";
            }

            return 0;
        }

        public void AddCar(Employee employee)
        {
            try
            {
                Init();

                if (employee == null)
                    throw new Exception("Invalid Car Record");

                result = conn.Insert(employee);
                StatusMessage = result == 0 ? "Insert Failed" : "Insert Successful";
            }
            catch (Exception ex)
            {
                StatusMessage = "Failed to Insert data.";
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            try
            {
                Init();

                if (employee == null)
                    throw new Exception("Invalid Car Record");

                result = conn.Update(employee);
                StatusMessage = result == 0 ? "Update Failed" : "Update Successful";
            }
            catch (Exception ex)
            {
                StatusMessage = "Failed to Update data.";
            }
        }

    }
}
