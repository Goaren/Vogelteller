using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    class Waarneming
    {
        private int id;
        private double x;
        private double y;
        private DateTime date;
        private Gebruiker gebruiker;
        private Gebied gebied;
        private Dier dier;
        private SoortWaarneming soortWaarneming;

        public int Id { get { return id;  } set { id = value;  } }
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
        public Gebruiker Gebruiker { get { return gebruiker; } set { gebruiker = value; } }
        public Gebied Gebied { get { return gebied; } set { gebied = value; } }
        public Dier Dier { get { return dier; } set { dier = value; } }
        public SoortWaarneming SoortWaarneming { get { return soortWaarneming; } set { soortWaarneming = value; } }

        public Waarneming(int id, double x, double y, DateTime date, Gebruiker gebruiker, Gebied gebied, Dier dier, SoortWaarneming soortWaarneming)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.date = date;
            this.gebruiker = gebruiker;
            this.gebied = gebied;
            this.dier = dier;
            this.soortWaarneming = soortWaarneming;
        }
    }
}
