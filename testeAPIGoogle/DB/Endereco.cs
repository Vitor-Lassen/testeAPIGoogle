using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace testeAPIGoogle.DB
{
    class Endereco
    {
        Conexao con = new Conexao();
        public void cadEnd(string end, string lng, string lat)
        {
            SqlCommand cmd = new SqlCommand("EXEC USP_CAD_END @ENDERECO , @LONG, @LAT",con.conectarDB());
            cmd.Parameters.Add("@ENDERECO", SqlDbType.VarChar).Value = end;
            cmd.Parameters.Add("@LONG", SqlDbType.VarChar).Value = lng;
            cmd.Parameters.Add("@LAT", SqlDbType.VarChar).Value = lat;
            cmd.ExecuteNonQuery();
            con.desconectarDB();
            MessageBox.Show("Cadastro realizado com sucesso!");
        }
        public DataSet consuEnd()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("EXEC USP_CONSU_TODOS_END", con.conectarDB());
            da.Fill(ds);
            con.desconectarDB();
            return ds;
        }
        public DataSet consuEnd(string end)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand("EXEC USP_CONSU_END @ENDERECO", con.conectarDB());
            cmd.Parameters.Add("@ENDERECO", SqlDbType.VarChar).Value = end;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.desconectarDB();
            return ds;
        }
    }
}
