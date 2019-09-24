using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiresias_V_alfa01.appCode.DAL
{
  class partituraDAL
  {

    private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Cleiton\\Desktop\\Tiresias_V_alfa01\\Tiresias_V_alfa01\\appData\\bancoDados.mdf;Integrated Security=True";
    private string sql = "";

    public int InsirirPartitura(Partitura partitura)
    {
      int id = 0;
      //sql = "INSERT INTO partitura (titulo, compasso, textoPartitura, pauta, braillePartitura, letraPartitura) ";
      //sql += " VALUES ('" + partitura.Titulo + "', '" + partitura.Compasso + "', '" + partitura.TextoPartitura + "' , '" + partitura.Pauta + "' , '" + partitura.BraillePartitura + "' , '" + partitura.LetraPartitura + "')";

      sql = " INSERT INTO partitura(titulo, compasso, textoPartitura, pauta, braillePartitura, letraPartitura) ";
      sql += " VALUES (@Ptitulo, @Pcompasso, @PtextoPartitura , @Ppauta , @PbraillePartitura , @PletraPartitura ) ";
      SqlConnection con = new SqlConnection(connectionString);
      SqlCommand cmd = new SqlCommand(sql, con);
      cmd.Parameters.AddWithValue("@Ptitulo", partitura.Titulo);
      cmd.Parameters.AddWithValue("@Pcompasso", partitura.Compasso);
      cmd.Parameters.AddWithValue("@PtextoPartitura", partitura.TextoPartitura);
      cmd.Parameters.AddWithValue("@Ppauta", partitura.Pauta);
      cmd.Parameters.AddWithValue("@PbraillePartitura", partitura.BraillePartitura);
      cmd.Parameters.AddWithValue("@PletraPartitura", partitura.LetraPartitura);

      con.Open();
      try
      {
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
          cmd = new SqlCommand("SELECT MAX(Id) FROM partitura", con);
          id = Convert.ToInt32(cmd.ExecuteScalar());
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro: " + ex.ToString());
      }
      finally
      {
        con.Close();
      }
      return id;
    }

    public bool AlterarPartitura(Partitura partitura)
    {
      bool verifica = false;
      sql = "UPDATE partitura ";
      sql += " SET compasso= @Pcompasso, textoPartitura= @PtextoPartitura, Pauta = @PPauta , BraillePartitura = @PBraillePartitura , LetraPartitura = @PLetraPartitura";
      sql += " WHERE id=@Pid";
      SqlConnection con = new SqlConnection(connectionString);
      SqlCommand cmd = new SqlCommand(sql, con);
      cmd.Parameters.AddWithValue("@Pid", partitura.Id);
      cmd.Parameters.AddWithValue("@Pcompasso", partitura.Compasso);
      cmd.Parameters.AddWithValue("@PtextoPartitura", partitura.TextoPartitura);
      cmd.Parameters.AddWithValue("@Ppauta", partitura.Pauta);
      cmd.Parameters.AddWithValue("@PbraillePartitura", partitura.BraillePartitura);
      cmd.Parameters.AddWithValue("@PletraPartitura", partitura.LetraPartitura);


      con.Open();
      try
      {
        cmd.ExecuteNonQuery();
        verifica = true;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro: " + ex.ToString());
      }
      finally
      {
        con.Close();
      }
      return verifica;
    }

    public List<Partitura> GetAllPartitura()
    {
      List<Partitura> lista = new List<Partitura>();
      
      sql = "SELECT * FROM partitura";
      SqlConnection con = new SqlConnection(connectionString);
      con.Open();
      SqlCommand cmd = new SqlCommand(sql, con);
      SqlDataReader reader = cmd.ExecuteReader();
      while (reader.Read())
      {
        Partitura part = new Partitura();
        part.Id = int.Parse(reader[0].ToString());
        part.Titulo = reader[1].ToString();
        part.Compasso = reader[2].ToString();
        part.TextoPartitura = reader[3].ToString();
        lista.Add(part);
      }
      con.Close();
      reader.Close();
      return lista;
    }

    public bool auxiliar(int aux)
    {
      bool verifica = false;
      sql = "UPDATE auxiliar ";
      sql += " SET partituraId= "+ aux;
      sql += " WHERE id=" + 1;

      SqlConnection con = new SqlConnection(connectionString);
      SqlCommand cmd = new SqlCommand(sql, con);
      con.Open();
      try
      {
        cmd.ExecuteNonQuery();
        verifica = true;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro: " + ex.ToString());
      }
      finally
      {
        con.Close();
      }
      return verifica;
    }

    private int getIdPartitura_auxiliar()
    {
      int id = 0;
      sql = "SELECT * FROM auxiliar ";
      sql += " WHERE id=" + 1;

      SqlConnection con = new SqlConnection(connectionString);
      con.Open();
      SqlCommand cmd = new SqlCommand(sql, con);
      SqlDataReader reader = cmd.ExecuteReader();
      while (reader.Read())
      {
        id = int.Parse(reader[1].ToString());
      }
      con.Close();
      reader.Close();
      return id;
    }


    public Partitura GetPartitura()
    {
      Partitura partitura = new Partitura();
      int id = getIdPartitura_auxiliar();

      sql = "SELECT * FROM partitura where id=" + id.ToString();
      SqlConnection con = new SqlConnection(connectionString);
      con.Open();
      SqlCommand cmd = new SqlCommand(sql, con);
      SqlDataReader reader = cmd.ExecuteReader();
      while (reader.Read())
      {
        partitura.Id = int.Parse(reader[0].ToString());
        partitura.Titulo = reader[1].ToString();
        partitura.Compasso = reader[2].ToString();
        partitura.TextoPartitura = reader[3].ToString();
        partitura.Pauta = reader[4].ToString();
        partitura.BraillePartitura = reader[5].ToString();
        partitura.LetraPartitura = reader[6].ToString();
      }
      con.Close();
      reader.Close();
      return partitura;
    }

    public bool DeletarPartitura(int id)
    {
      bool verifica = false;
      sql = "DELETE FROM partitura WHERE id=" + id;

      SqlConnection con = new SqlConnection(connectionString);
      SqlCommand cmd = new SqlCommand(sql, con);
      con.Open();
      try
      {
        cmd.ExecuteNonQuery();
        verifica = true;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Erro: " + ex.ToString());
      }
      finally
      {
        con.Close();
      }
      return verifica;
    }
  }
}
