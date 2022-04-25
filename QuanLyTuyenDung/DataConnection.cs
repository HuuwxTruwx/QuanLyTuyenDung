using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyTuyenDung
{
    internal class DataConnection
    {
        string ConnectionString = "Data Source = DESKTOP-P7KNOQI; Initial Catalog = QUANLYTUYENDUNG, UID=sa,PWD=123456a@";
        SqlConnection con;
 
        public void OpenConection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
              "Data Source=DESKTOP-P7KNOQI;" +
              "Initial Catalog=QUANLYTUYENDUNG;" +
              "User id=sa;" +
              "Password=123456a@;";
            conn.Open();
            SqlCommand cmd=conn.CreateCommand();
            cmd.CommandText = "Select * from UngVien";
            using (System.Data.Common.DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        // Chỉ số của cột Emp_ID trong câu lệnh SQL.
                        int empIdIndex = reader.GetOrdinal("IdUngVien"); // 0


                        long empId = Convert.ToInt64(reader.GetValue(0));

                        // Cột Emp_No có index = 1.
                        string empNo = reader.GetString(1);
                        int empNameIndex = reader.GetOrdinal("Ten");// 2
                        string empName = reader.GetString(empNameIndex);

                        // Chỉ số của cột Mng_Id trong câu lệnh SQL.
                        int mngIdIndex = reader.GetOrdinal("Tuoi");

                        long? mngId = null;


                        if (!reader.IsDBNull(mngIdIndex))
                        {
                            mngId = Convert.ToInt64(reader.GetValue(mngIdIndex));
                        }
                        Debug.WriteLine("--------------------");
                        Debug.WriteLine("empIdIndex:" + empIdIndex);
                        Debug.WriteLine("EmpId:" + empId);
                        Debug.WriteLine("EmpNo:" + empNo);
                        Debug.WriteLine("EmpName:" + empName);
                        Debug.WriteLine("MngId:" + mngId);
                      
                    }
                }
            }



            //con = new SqlConnection(ConnectionString);
            //con.Open();
        }
        public SqlConnection getConnect()
        {
            string connectString = "Data Source=DESKTOP-P7KNOQI;" +
              "Initial Catalog=QUANLYTUYENDUNG;" +
              "User id=sa;" +
              "Password=123456a@;";
            return new SqlConnection(connectString);
        }

        public void CloseConnection()
        {
            con.Close();
        }


        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }


        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
    }
}
