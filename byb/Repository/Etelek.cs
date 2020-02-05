﻿using byb.Database;
using byb.Modell;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Repository
{
    class Etelek
    {
        private readonly string connectionString;
        ConnectionString cs = new ConnectionString();
        List<Etel> etelek;
        public Etelek()
        {
            etelek = new List<Etel>();
            connectionString = cs.getConnectionString();
        }
        public List<Etel> getEtelek()
        {
            return etelek;
        }
        public void setEtelek(List<Etel> etelek)
        {
            this.etelek = etelek;
        }
        public List<Etel> getEtelekAdatbazisbol()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
                string query = Etel.getAllEtelekRecord();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["etel_id"]);
                    string nev = dr["enev"].ToString();
                    int ka = Convert.ToInt32(dr["kaloria"]);
                    int fe = Convert.ToInt32(dr["feherje"]);
                    int sz = Convert.ToInt32(dr["szenhidrat"]);
                    int zs = Convert.ToInt32(dr["zsir"]);
                    string menny = dr["mennyiseg"].ToString();
                    Etel e = new Etel(id,nev,ka,fe,sz,zs,menny);
                    etelek.Add(e);
                }
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("A kiegészítők adatainak kiolvasása sikertelen");
            }
            return etelek;

        }
        public DataTable getListabolDataTable()
        {
            DataTable etelekDT = new DataTable();
            etelekDT.Columns.Add("enev", typeof(string));
            etelekDT.Columns.Add("kaloria", typeof(int));
            etelekDT.Columns.Add("feherje", typeof(int));
            etelekDT.Columns.Add("szenhidrat", typeof(int));
            etelekDT.Columns.Add("zsir", typeof(int));
            etelekDT.Columns.Add("mennyiseg", typeof(string));
            foreach(Etel e in etelek)
            {
                etelekDT.Rows.Add(e.Nev, e.Kaloria, e.Feherje, e.Szenhidrat, e.Zsir, e.Mennyiseg);
            }
            return etelekDT;
        }
    }
}
