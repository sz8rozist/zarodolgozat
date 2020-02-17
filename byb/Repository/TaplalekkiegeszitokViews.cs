using byb.Modell;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Repository
{
   partial class Repo
    {
        List<TaplalekkiegeszitokView> tkiegview;

        /* public TaplalekkiegeszitokViews(int userID, List<Kiegeszito> kieg, List<KiegAdat> kiegadatok)
         {

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
         }*/
        public List<TaplalekkiegeszitokView> getTapkiegekListakbolUIDAlapjan(int userID, List<Kiegeszito> kieg, List<KiegAdat> kiegadatok)
        {
            List<Kiegeszito> k = kieg.FindAll(x => x.F_id == userID);
            foreach (Kiegeszito tapkieg in k)
            {

                KiegAdat kiegadat = kiegadatok.Find(x => x.Kid == tapkieg.K_id);
                if (kiegadat != null)
                {
                    TaplalekkiegeszitokView tkgv = new TaplalekkiegeszitokView(kiegadat.Knev, kiegadat.Tipus, kiegadat.Gyarto);
                    tkiegview.Add(tkgv);
                }

            }
            return tkiegview;
        }
        public List<TaplalekkiegeszitokView> getTkiegView()
        {
            return tkiegview;
        }
        public void setTkiegView(List<TaplalekkiegeszitokView> tkiegview)
        {
            this.tkiegview = tkiegview;
        }
        public void addTkiegViewList(TaplalekkiegeszitokView ujtkiegview)
        {
            try
            {
                tkiegview.Add(ujtkiegview);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
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
