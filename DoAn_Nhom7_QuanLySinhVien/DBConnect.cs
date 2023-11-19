﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAn_Nhom7_QuanLySinhVien
{
    class DBConnect
    {
        SqlConnection connect;

        public SqlConnection Connect
        {
            get { return connect; }
            set { connect = value; }
        }
        string strConnect = "Data Source = THY; Initial Catalog = QL__sinhVien11; User ID =sa; Password = sa";
        public DBConnect()
        {
            connect = new SqlConnection(strConnect);
        }

        public void open()
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
        }
        public void close()
        {
            if (connect.State == ConnectionState.Open)
                connect.Close();
        }
        public int getNonQuery(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            int kq = cmd.ExecuteNonQuery();
            close();
            return kq;
        }
        public SqlDataReader getDataReader(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            SqlDataReader rd = cmd.ExecuteReader();
            //close();
            return rd;
        }

        public object getScalar(string sql)
        {
            open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            object kq = cmd.ExecuteScalar();
            close();
            return kq;
        }

        public DataTable getDatatable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(dt);
            return dt;
        }

        public int updateDatabase(string sql, DataTable dt)
        {
            SqlDataAdapter da_lop = new SqlDataAdapter(sql, Connect);
            SqlCommandBuilder cb = new SqlCommandBuilder(da_lop);
            int kq = da_lop.Update(dt);
            return kq;
        }
    }
}
