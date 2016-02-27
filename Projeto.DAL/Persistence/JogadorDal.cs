using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projeto.Entity.Entities;

namespace Projeto.DAL.Persistence
{
    public class JogadorDal : Conexao
    {
        public void Insert(Jogador j)
        {
            try
            {
                OpenConnection();

                Cmd = new SqlCommand("INSERT INTO TB_JOGADOR(NOME, APELIDO, DATANASCIMENTO, POSICAO, IDTIME) VALUES(@v1, @v2, @v3, @v4, @v5)", Con);
                Cmd.Parameters.AddWithValue("@v1", j.Nome);
                Cmd.Parameters.AddWithValue("@v2", j.Apelido);
                Cmd.Parameters.AddWithValue("@v3", j.DataNascimento);
                Cmd.Parameters.AddWithValue("@v4", j.Posicao);
                Cmd.Parameters.AddWithValue("@v5", j.IdTime);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(Jogador j)
        {
            try
            {
                OpenConnection();

                Cmd = new SqlCommand("UPDATE TB_JOGADOR SET NOME = @v1, APELIDO = @v2, DATANASCIMENTO = @v3, POSICAO = @v4, IDTIME = @v5 WHERE IDJOGADOR = @v6", Con);
                Cmd.Parameters.AddWithValue("@v1", j.Nome);
                Cmd.Parameters.AddWithValue("@v2", j.Apelido);
                Cmd.Parameters.AddWithValue("@v3", j.DataNascimento);
                Cmd.Parameters.AddWithValue("@v4", j.Posicao);
                Cmd.Parameters.AddWithValue("@v5", j.IdTime);
                Cmd.Parameters.AddWithValue("@v6", j.IdJogador);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Delete(int Id)
        {
            try
            {
                OpenConnection();

                Cmd = new SqlCommand("DELETE FROM TB_JOGADOR WHERE IDJOGADOR = @v1", Con);
                Cmd.Parameters.AddWithValue("@v1", Id);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<Jogador> FindAll()
        {
            try
            {
                OpenConnection();

                Cmd = new SqlCommand("SELECT j.IDJOGADOR, j.NOME, j.APELIDO, j.DATANASCIMENTO, j.POSICAO, t.NOME as 'TIME' FROM TB_JOGADOR as j INNER JOIN TB_TIME as t on j.IDTIME = t.IDTIME", Con);
                Dr = Cmd.ExecuteReader();

                List<Jogador> lista = new List<Jogador>();

                while(Dr.Read())
                {
                    Jogador j = new Jogador();
                    j.IdJogador = Convert.ToInt32(Dr["IDJOGADOR"]);
                    j.Nome = Convert.ToString(Dr["NOME"]);
                    j.Apelido = Convert.ToString(Dr["APELIDO"]);
                    j.DataNascimento = Convert.ToDateTime(Dr["DATANASCIMENTO"]);
                    j.Posicao = Convert.ToString(Dr["POSICAO"]);

                    j.Time = new Time();
                    j.Time.Nome = Convert.ToString(Dr["TIME"]);
                    
                    lista.Add(j);
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
