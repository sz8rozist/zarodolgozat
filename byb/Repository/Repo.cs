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
            etelek = new List<Etel>();
            etkezesek = new List<Etkezes>();
            etkezesekviewn = new List<EtkezesView>();
            gyakorlatok = new List<Gyakorlat>();
            izomcsoportok = new List<Izomcsoport>();
        }
    }
}
