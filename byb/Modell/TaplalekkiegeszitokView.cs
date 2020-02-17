using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    /// <summary>
    /// Táblálékkiegészítők a View-n osztály
    /// </summary>
    class TaplalekkiegeszitokView
    {
        /// <summary>
        /// Az osztály adatai
        /// </summary>
        private string nev;
        private string tipus;
        private string gyarto;
        /// <summary>
        /// Paraméteres konstruktor az osztály adataival
        /// </summary>
        /// <param name="nev">Taplalekkiegeszito Név</param>
        /// <param name="tipus">Típus</param>
        /// <param name="gyarto">Gyártó</param>
        public TaplalekkiegeszitokView(string nev, string tipus, string gyarto)
        {
            this.nev = nev;
            this.tipus = tipus;
            this.gyarto = gyarto;
        }
        /// <summary>
        /// Set - get metódusok
        /// </summary>
        public string Nev { get => nev; set => nev = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Gyarto { get => gyarto; set => gyarto = value; }
    }
}
