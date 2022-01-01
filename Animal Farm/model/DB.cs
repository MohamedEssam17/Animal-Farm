using System;

using System.Data.SqlClient;


namespace model
{
    class DB
    {
        public static SqlConnection openConnection()
        {

            var con = new SqlConnection(@"server=DESKTOP-NKRK2K3\SQLEXPRESS; database=farm;integrated security =true;");
            con.Open();
            return con;
        }
        public static bool isValidUser(String u_name, String password, SqlConnection connection)
        {

            string qu = String.Format("select * from Tabel_users where ID='{0}' and password='{1}'", u_name, password);

            connection.Open();

            SqlCommand cmd = new SqlCommand(qu, connection);
            var reader = cmd.ExecuteReader();


            var back = reader.Read();
            reader.Close();
            connection.Close();
            return back;



        }
    }


}
