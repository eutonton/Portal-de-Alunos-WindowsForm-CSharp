using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Portal.Infraestructure
{
    public class AlunoRespository
    {
        public bool Add(Aluno aluno)
        {
            using var conn = new DbConnection();

            string query = @"INSERT INTO public.aluno(
	                        nome, curso, idade)
	                        VALUES ( @nome, @curso, @idade);";

            var result = conn.Connection.Execute(sql: query, param:aluno);

            return result == 1;
        }

        public List<Aluno> Get()
        {
            using var conn = new DbConnection(); 
            string query = @"SELECT * FROM aluno;";

            var aluno = conn.Connection.Query<Aluno>(sql: query);

            return aluno.ToList();
        }
    }
}
