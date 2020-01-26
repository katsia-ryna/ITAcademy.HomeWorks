using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data.SqlClient;

namespace HW12.Task1
{
    class MotorcycleRepository
    {
        static SqlConnection connection;
        
        public MotorcycleRepository()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='motorcycles.mdf';Integrated Security=True");
            connection.Open();
        }

        public Motorcycle GetMotorcycleById(int id)
        {
            return new Motorcycle();
        }

        public void GetMotorcycles()
        {
        }

        public void CreateMotorcycle(Motorcycle motorcycle)
        {
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
        }

        public void DeleteMotorcycle(int id)
        {
        }
    }
}
