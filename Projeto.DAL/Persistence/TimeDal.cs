using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projeto.Entity.Entities;

namespace Projeto.DAL.Persistence
{
    public class TimeDal : Conexao
    {
        public void Insert(Time t)
        {
            try
            {
                OpenConnection();

                Cmd = new SqlCommand("INSERT INTO TB_TIME(NOME, DATAFUNDACAO) VALUES(@v1, @v2)", Con);
                Cmd.Parameters.AddWithValue("@v1", t.Nome);
                Cmd.Parameters.AddWithValue("@v2", t.DataFundacao);
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

        public void Update(Time t)
        {
            try
            {
                OpenConnection();

                Cmd = new SqlCommand("UPDATE TB_TIME SET NOME = @v1, DATAFUNDACAO = @v2 WHERE IDTIME = @v3", Con);
                Cmd.Parameters.AddWithValue("@v1", t.Nome);
                Cmd.Parameters.AddWithValue("@v2", t.DataFundacao);
                Cmd.Parameters.AddWithValue("@v3", t.IdTime);
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

                Cmd = new SqlCommand("DELETE FROM TB_TIME WHERE IDTIME = @v1", Con);
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

        public List<Time> FindAll()
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("SELECT * FROM TB_TIME", Con);
                Dr = Cmd.ExecuteReader();

                List<Time> lista = new List<Time>();

                while(Dr.Read())
                {
                    Time t = new Time();
                    t.IdTime = Convert.ToInt32(Dr["IDTIME"]);
                    t.Nome = Convert.ToString(Dr["NOME"]);
                    t.DataFundacao = Convert.ToDateTime(Dr["DATAFUNDACAO"]);

                    lista.Add(t);
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
