using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _070419
{
    class EmployeDAO : IEmployeeDAO
    {
        //UPDATE Department SET TotalEmp = (SELECT count(*) FROM Employee WHERE Employee.Department_ID = Department.ID)
        
        
  
        public List<object> GetTotalEmployesOfDepartment()
        {
             
            string dbName = @"C:\Users\HackerU\ely0704.db";
            List<object> results = new List<object>();
            using (var connection = new SQLiteConnection($"Data Source = {dbName}; Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand($"SELECT E.ID, E.NAME AS EMP_NAME, D.NAME AS DEP_NAME FROM EMPLOYEE E JOIN DEPARTMENT D ON E.DEPARTMENT_ID=D.ID", connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var obj = new
                            {
                                Employee_Id = (Int64)reader["ID"],
                                Employee_Name = (string)reader["EMP_NAME"],
                                Department_Name = (string)reader["DEP_NAME"],
                            };
                            results.Add(obj);
                        }
                       
                        
                    }
                }
                    return results;
            }
        }
    }
}
