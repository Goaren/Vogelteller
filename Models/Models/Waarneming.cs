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

        public int Id { get { return id;  } set { id = value;  } }
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public DateTime Date { get { return date; } set { date = value; } }

        public Waarneming(int id, double x, double y, DateTime date)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.date = date;
        }
    }
}
