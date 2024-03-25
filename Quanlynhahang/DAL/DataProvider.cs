using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhahang.DAL
{
    public class DataProvider
    {
        private DataProvider() { }

        private string connectionString = @"Data Source=LAPTOPCUATAO;Initial Catalog=QuanLyNhaHang;Integrated Security=True";

        // tạo mô hình singleton
        private static DataProvider instance;

        public static DataProvider Instance 
        { 
            get { if (instance == null) instance = new DataProvider(); return instance; } 
            private set => instance = value; 
        }
        // tạo phương thức truy vấn csdl
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);

            if (parameter != null)
            {
                string[] lisPara = query.Split(' ');
                int i = 0;
                foreach (string item  in lisPara)
                {
                    if (item.Contains('@'))
                    {
                        cmd.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);

            connection.Close();
            return data;

        }

        //thực thi lệnh sql k truy vấn 
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);

            if (parameter != null)
            {
                string[] lisPara = query.Split(' ');
                int i = 0;
                foreach (string item in lisPara)
                {
                    if (item.Contains('@'))
                    {
                        cmd.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }

            data = cmd.ExecuteNonQuery();

            connection.Close();
            return data;

        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);

            if (parameter != null)
            {
                string[] lisPara = query.Split(' ');
                int i = 0;
                foreach (string item in lisPara)
                {
                    if (item.Contains('@'))
                    {
                        cmd.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }

            data = cmd.ExecuteScalar();

            connection.Close();
            return data;

        }
    }
}
