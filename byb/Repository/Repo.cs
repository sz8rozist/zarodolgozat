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
            //Repositoryban connectionString példányosítása
            connectionString = cs.getConnectionString();
            //Listák példányosítása a repoban
            users = new List<Felhasznalo>();
            etkezesek = new List<Etkezes>();
            etelek = new List<Etel>();
            kiegek = new List<KiegAdat>();
            tkiegek = new List<Kiegeszito>();
            etrendek = new List<Etrend>();
            tkiegview = new List<TaplalekkiegeszitokView>();

        }
    }
}
