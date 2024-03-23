using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;

namespace DAL
{
    public class SqlconnectionData
    {
        // tao chuoi ket noi csdl
        public static SqlConnection Connect()
        {
            //string strcon = @"Data Source=DESKTOP-F55VHGS;Initial Catalog=QLSHOPAOQUAN;Integrated Security=True";
            string strcon = @"Data Source=.;Initial Catalog=winform;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon); // khoi tao connect
            return conn;
        }
    }
    public class DatabaseAccess
    {
        public static string CheckLogicDTO(TaiKhoan taikhoan)
        {
            string user = null;
            // Ham connect toi csdl
            SqlConnection conn = SqlconnectionData.Connect();
            conn.Open();
            /*SqlCommand command = new(" proc_logic", conn);*/
            SqlCommand command = new("proc_logic", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", taikhoan.sTaiKhoan);
            command.Parameters.AddWithValue("@pass", taikhoan.sMatKhau);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //user = reader.GetString(0);
                    user = reader.GetInt32(4).ToString();
                    return user;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tai khoan hoac mat khau khong chinh xac!";
            }
            Console.WriteLine(user);
            return user;
           
        }
        
        public static bool CheckRegisterExistDTO(TaiKhoan taikhoan)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            string query = "Select * from tbl_taikhoan where sEmail = '" + taikhoan.sEmail + "'";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                reader.Close();
                conn.Close();
                return false;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //return false;
        }
        public static bool CheckRegisterDTO(TaiKhoan taiKhoan)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            string query = "Insert into tbl_taikhoan values ('" + taiKhoan.sTaiKhoan + "','" + taiKhoan.sMatKhau + "','" + taiKhoan.sEmail + "','" + 3 + "')";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                conn.Close();
                return false;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool AddStaffDTO(TaiKhoan taiKhoan)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            string query = "Insert into tbl_taikhoan values ('" + taiKhoan.sTaiKhoan + "','" + taiKhoan.sMatKhau + "','" + taiKhoan.sEmail + "','" + 2 + "')";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                conn.Close();
                return false;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool UpdateStaffDTO(TaiKhoan taiKhoan)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            string query = $"Update tbl_taikhoan set sTaiKhoan = '{taiKhoan.sTaiKhoan}', sMatKhau = '{taiKhoan.sMatKhau}', sEmail = '{taiKhoan.sEmail}' where sMaTK = '{taiKhoan.sMaTK}'";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                conn.Close();
                return false;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool DeleteStaffDTO(TaiKhoan taiKhoan)
        {
            SqlConnection conn = SqlconnectionData.Connect();
            string query = $"Delete tbl_taikhoan where sMaTK = '{taiKhoan.sMaTK}'";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                conn.Close();
                return false;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




        SqlDataAdapter dataAdapter;
        public DataTable Table(string query) //tra ve bang du lieu
        {
            DataTable dataTable = new DataTable();
            /*using (SqlConnection sqlConnection = Connection.GetSqlConnection());*/
            SqlConnection conn = SqlconnectionData.Connect();
            try
            {
                conn.Open();
                dataAdapter = new SqlDataAdapter(query, conn);
                dataAdapter.Fill(dataTable);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;

        }
        SqlCommand SqlCommand;
        public void Command(string query) // dung de them sua xoa
        {
            SqlConnection conn = SqlconnectionData.Connect();
            try
            {
                conn.Open();
                SqlCommand = new SqlCommand(query, conn);
                SqlCommand.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }

}
