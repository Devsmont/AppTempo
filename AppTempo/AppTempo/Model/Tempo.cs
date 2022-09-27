using System;
using System.Collections.Generic;
using System.Text;

namespace AppTempo.Model
{
    internal class Tempo
    {
        public string Titulo { get; set; }
        public string Temperatura { get; set; }
        public string Vento { get; set; }
        public string Umidade { get; set; }
        public string Visibilidade { get; set; }
        public string NascerSol { get; set; }
        public string PorSol { get; set; }

        public Tempo()
        {
            this.Titulo = "";
            this.Temperatura = "";
            this.Vento = "";
            this.Umidade = "";
            this.Visibilidade = "";
            this.NascerSol = "";
            this.PorSol = "";
        }

    }
}
