using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{


    public class DataProvider
    {
        public SqlConnection cn = new SqlConnection();
        public void Ketnoi()
        {
            try
            {
                if (cn.State == 0)
                {
                    cn.ConnectionString = @"Data Source=DESKTOP-8R0VE7P\SQLEXPRESS;Initial Catalog=NCP;Integrated Security=True";
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Ngatketnoi()
        {
            if (cn.State != 0)
            {
                cn.Close();
            }
        }

        // Hiển thị Dữ Liệu DataGridview

        public DataTable XemDLDGV(string sql, DataGridView dgv)
        {
            Ketnoi();

            SqlDataAdapter adap = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dgv.DataSource = dt;
            return dt;
            Ngatketnoi();
        }

        public DataTable XemDL(string sql)
        {
            Ketnoi();
            SqlDataAdapter adap = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
            Ngatketnoi();
        }
        //Phương thức truy vấn dữ liệu: Insert, Update, Delete
        public SqlCommand ThucThiDl(string sql)
        {
            Ketnoi();

            SqlCommand cm = new SqlCommand(sql, cn);
            int i = cm.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("thêm thành công");
            }
            else
            {
                MessageBox.Show("thêm không thành công");

            }
            return cm;

            Ngatketnoi();
        }
        public SqlDataReader getdata(string sql)
        {
            Ketnoi();
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
            Ngatketnoi();
        }
        //DataSet
        //DataReader

    }


}
