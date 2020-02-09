using byb.Database;
using byb.Modell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Repository
{
    partial class Repo
    {
        private readonly string connectionString;
        ConnectionString cs = new ConnectionString();
        public Repo()
        {
            connectionString = cs.getConnectionString();
            users = new List<Felhasznalo>();
            logins = new List<Login>();
            etkezesek = new List<Etkezes>();
            etelek = new List<Etel>();
            tkiegek = new List<Taplalekkiegeszito>();
        }
    }
}
