using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06
{
    class SportovecAmater
    {
        private string jmeno;
        private int pocetHodinTreninku = 0;
        private double hmotnost;
        private double vyska;
        public double Hmotnost
        {
            get
            {
                return hmotnost;
            }
            set
            {
                hmotnost = value;
            }
        }
        public double Vyska
        {
            get 
            {
                return vyska;
            }
            set
            {
                vyska = value;
            }
        }
        public SportovecAmater(string jmeno, double hmotnost, double vyska)
        {
            this.jmeno = jmeno;
            Hmotnost = hmotnost;
            Vyska = vyska;
        }
        public virtual void Trenuj(int pocetHodinTreninku)
        {
            this.pocetHodinTreninku += pocetHodinTreninku;
        }
        public double BMI()
        {
            double bmi = Hmotnost / (Vyska * Vyska);
            return bmi;
        }
        public override string ToString()
        {
            string s = "\nBMI je: " + BMI() +
                "\nPočet Hodin tréninku je: " + pocetHodinTreninku;
            return base.ToString() + s;
        }
    }
}
