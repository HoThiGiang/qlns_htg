using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{
    public class DBConnection: DataTable
    {
        public static SqlConnection m_Connection;
        SqlDataAdapter m_DataAdapter;
        SqlCommand m_Command;
        SqlDataReader sqldr;

        public static string strConn = (@"Data Source=.\SqlExpress;Initial Catalog=QuanLiNhanSu_BTL;Integrated Security=True");
        
        public DBConnection()
        {
        }

        //Insert dữ liệu

        public int ExecuteNoneQuery()
        {
            int result = 0;
            SqlTransaction tr = null;
            try
            {
                tr = m_Connection.BeginTransaction();

                m_Command.Connection = m_Connection;
                m_Command.Transaction = tr;

                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                SqlCommandBuilder builder = new SqlCommandBuilder(m_DataAdapter);

                result = m_DataAdapter.Update(this);
                tr.Commit();

            }
            catch (Exception e)
            {
                if (tr != null) tr.Rollback();

            }
            return result;
        }
        /// <summary>
        /// Thuc thi mot command
        /// </summary>
        /// <param name = "command" > OleDb hay Store Procedure</param>
        /// <returns></returns>
        public int ExecuteNoneQuery(SqlCommand cmd)
        {

            int result = 0;
            SqlTransaction tr = null;

            try
            {
                tr = m_Connection.BeginTransaction();

                cmd.Connection = m_Connection;

                cmd.Transaction = tr;

                result = cmd.ExecuteNonQuery();

                this.AcceptChanges();

                tr.Commit();

            }
            catch (Exception e)
            {
                if (tr != null) tr.Rollback();
                throw;
            }
            return result;

        }
        //Kết quả trả về là một giá trị

        public object ExecuteScalar(SqlCommand cmd)
        {
            object result = null;
            SqlTransaction tr = null;

            tr = m_Connection.BeginTransaction();

            cmd.Connection = m_Connection;

            cmd.Transaction = tr;

            result = cmd.ExecuteScalar();

            this.AcceptChanges();

            tr.Commit();

            if (result == DBNull.Value)
            {
                result = null;
            }
            return result;
        }
        
        //kiểm tra trùng khóa
        public bool kttrungkhoa(string dauvao, string strsql)
        {
            bool ok = false;
            m_Connection.Open();
            m_Command = new SqlCommand(strsql, m_Connection);
            sqldr = m_Command.ExecuteReader();
            while (sqldr.Read())
            {
                if (sqldr[0].ToString().ToLower() == dauvao.ToLower())
                    ok = true;
            }
            m_Connection.Close();
            return ok;
        }

        //hàm trả về table
        public DataTable GetTable(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, strConn);
            DataTable dt = new DataTable();
            try
            {
                if (m_Connection.State != ConnectionState.Open)
                    m_Connection.Open();

                da.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            return dt;
        }
        
        //public int ExecuteSPNoneQuery(string strCode)
        //{
        //    // Trả vể số lượng bản ghi thực hiện được khi thực thi câu lệnh. 
        //    int result = 0;
        //    if (strCode != "")
        //    {
        //        if (m_Connection.State == ConnectionState.Closed)
        //            m_Connection.Open();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = m_Connection;
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = strCode;
        //        result = cmd.ExecuteNonQuery();

        //        if (m_Connection.State == ConnectionState.Open)
        //            m_Connection.Close();
        //    }
        //    return result;
        //}

        //Load
        public void Load(SqlCommand command)
        {
            m_DataAdapter = new SqlDataAdapter();
            m_Command = new SqlCommand();
            if (m_Connection == null || m_Connection.State == ConnectionState.Closed)
            {
                m_Connection = new SqlConnection(strConn);
                m_Connection.Open();
            }

            m_Command = command;
            m_Command.Connection = m_Connection;
            m_DataAdapter = new SqlDataAdapter(m_Command);
            this.Clear();
            m_DataAdapter.Fill(this);
        }
        //Hàm kết nối
        public void ketnoi()
        {
            m_Connection = new SqlConnection(strConn);
            m_Connection.Open();
        }
        //Hàm kết nối
        public void ketnoi(string query)
        {
            m_Command = new SqlCommand(query,m_Connection);
            m_Connection = new SqlConnection(strConn);
            m_Connection.Open();
        }
        //Hàm ngắt kết nối
        public void ngatketnoi()
        {
            m_Connection.Close();
        }
        //Thực thi kết nối
        public void thucthiketnoi(string strsql)
        {
            ketnoi();
            m_Command = new SqlCommand(strsql, m_Connection);
            m_Command.ExecuteNonQuery();
            ngatketnoi();
        }
        //Ngoại lệ
        public void Execute(string sql)
        {
            ketnoi();
            SqlCommand command = new SqlCommand(sql, m_Connection);
            //command.ExecuteNonQuery();
            ExecuteNoneQuery(command);
            ngatketnoi();
        }
        
        //kiểm tra kết nối
        public static bool OpenConnection()
        {
            try
            {
                if (m_Connection == null)
                    m_Connection = new SqlConnection(strConn);
                if (m_Connection.State == ConnectionState.Closed)
                    m_Connection.Open();
                return true;
            }
            catch
            {
                m_Connection.Close();
                return false;
            }
        }


        public void Update()
        {
            SqlCommandBuilder buider = new SqlCommandBuilder(m_DataAdapter);
            m_DataAdapter.Update(this);
        }
        



    }
}



































