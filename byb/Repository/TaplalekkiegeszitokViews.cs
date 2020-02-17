using byb.Modell;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Repository
{
    class TaplalekkiegeszitokViews
    {
        List<TaplalekkiegeszitokView> tkiegview;

        public TaplalekkiegeszitokViews(int userID, List<Kiegeszito> kieg, List<KiegAdat> kiegadatok)
        {
            tkiegview = new List<TaplalekkiegeszitokView>();
            List<Kiegeszito> k = kieg.FindAll(x => x.F_id == userID);
            foreach(Kiegeszito tapkieg in k)
            {

                KiegAdat kiegadat = kiegadatok.Find(x => x.Kid == tapkieg.K_id);
                if(kiegadat != null)
                {
                    TaplalekkiegeszitokView tkgv = new TaplalekkiegeszitokView(kiegadat.Knev, kiegadat.Tipus,kiegadat.Gyarto);
                    tkiegview.Add(tkgv);
                }

            }
        }
        public DataTable getTkgViewDT()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("knev", typeof(string));
            dt.Columns.Add("tipus", typeof(string));
            dt.Columns.Add("gyarto", typeof(string));

            foreach (TaplalekkiegeszitokView tkg in tkiegview)
            {
                dt.Rows.Add(tkg.Nev,tkg.Tipus,tkg.Gyarto);
            }
            return dt;
        }
    }
}
