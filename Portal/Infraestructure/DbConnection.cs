using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Infraestructure
{
    public class DbConnection : IDisposable
    {
        public NpgsqlConnection Connection { get; set; }

        public DbConnection() 
        {
            Connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=portal_do_aluno_;User Id=postgres;Password=123456;");
            Connection.Open();
            
        }

        public void Dispose() 
        {
            Connection.Close();
        }
    }
}
