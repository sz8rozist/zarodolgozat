using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class Kiegeszito
    {
        private int kiegid;
        private int k_id;
        private int f_id;

        public Kiegeszito(int kiegid, int k_id, int f_id)
        {
            this.kiegid = kiegid;
            this.k_id = k_id;
            this.f_id = f_id;
        }
        public Kiegeszito(int k_id, int f_id)
        {
            this.k_id = k_id;
            this.f_id = f_id;
        }

        public int Kiegid { get => kiegid; set => kiegid = value; }
        public int K_id { get => k_id; set => k_id = value; }
        public int F_id { get => f_id; set => f_id = value; }

        public string insertIntoKiegeszito()
        {
            return "INSERT INTO `kiegeszitok`(`k_id`, `f_id`) VALUES ('"+K_id+"','"+F_id+"')";
        }
    }
}
