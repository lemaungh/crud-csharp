using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Student
{
    public class DataProvider
    {
        const string connectString = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;TrustServerCertificate=True";
        private static SqlConnection connection;
        public static List<clsDangNhap> listDangNhap = new List<clsDangNhap>();
        public static void OpenConnection()
        {
            connection = new SqlConnection(connectString); // khoi tao database
            connection.Open();
        }
        public static void CloseConnection() {
            connection.Close();
        }
        public static void getAllUser()
        {
            try
            {
                OpenConnection();
                string query = "select * from tblLogin";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    clsDangNhap dangNhap = new clsDangNhap();
                    dangNhap.tenDangNhap = reader["Username"].ToString();
                    dangNhap.matKhau = reader["Userpassword"].ToString();
                    dangNhap.quyen = reader["UserLoginPermission"].ToString();
                    listDangNhap.Add(dangNhap);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                CloseConnection(); 
            }

        }
        public static DataTable loadData(string query)
        {
            DataTable dt = new DataTable();
            try 
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dt;

        }
    }
}
