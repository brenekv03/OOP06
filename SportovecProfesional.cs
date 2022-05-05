using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06
{
    class SportovecProfesional:SportovecAmater
    {
        private double bazalniMetabolismus;
        public SportovecProfesional(string jmeno, double hmotnost, double vyska, double bazalniMetabolismus):base(jmeno,hmotnost,vyska)
        {
            this.bazalniMetabolismus = bazalniMetabolismus;
        }
        public override void Trenuj(int pocetHodinTreninku)
        {
            bazalniMetabolismus += (bazalniMetabolismus / 100) * 110;
            base.Trenuj(pocetHodinTreninku);
        }
        public override string ToString()
        {
            return base.ToString() + "\nBazální metabolismus je: " + bazalniMetabolismus;
        }
    }
}
