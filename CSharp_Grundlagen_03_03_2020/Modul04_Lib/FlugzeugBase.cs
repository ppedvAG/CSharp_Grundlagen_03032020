﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul04_Lib
{
    public class FlugzeugBase : FahrzeugBase
    {

        private double spannweite;
        private int maxFlughoehe;
        private int aktFlughoehe;



        public FlugzeugBase(string marke, string modell, int baujahr, double maxGeschw, string farbe, double spannweite, int maxFlughoehe, int aktFlughoehe)
            : base(marke, modell, baujahr, maxGeschw, farbe)
        {
            this.Spannweite = spannweite;
            this.MaxFlughoehe = maxFlughoehe;
            this.AktFlughoehe = aktFlughoehe;
        }

        

        public double Spannweite { get => spannweite; set => spannweite = value; }
        public int MaxFlughoehe { get => maxFlughoehe; set => maxFlughoehe = value; }
        public int AktFlughoehe { get => aktFlughoehe; set => aktFlughoehe = value; }
    }

    public class Jet : FlugzeugBase
    {
        public Jet(string marke, string modell, int baujahr, double maxGeschw, string farbe, double spannweite, int maxFlughoehe, int aktFlughoehe, int düsenanzahl, double schubkraft) 
            : base(marke, modell, baujahr, maxGeschw, farbe, spannweite, maxFlughoehe, aktFlughoehe)
        {
            this.Düsenanzahl = düsenanzahl;
            this.Schubkraft = schubkraft;
        }

        int Düsenanzahl { get; set; }
        double Schubkraft { get; set; }
    }

    public class Propeller : FlugzeugBase
    {
        public Propeller(string marke, string modell, int baujahr, double maxGeschw, string farbe, double spannweite, int maxFlughoehe, int aktFlughoehe, int anzhalPropeller, int propellerUmdrehungenMin) 
            : base(marke, modell, baujahr, maxGeschw, farbe, spannweite, maxFlughoehe, aktFlughoehe)
        {
            this.AnzahlPropeller = anzhalPropeller;
            this.PropellerUmdrehungenMin = propellerUmdrehungenMin;
        }

        int AnzahlPropeller { get; set; }
        int PropellerUmdrehungenMin { get; set; }

    }


    
}
