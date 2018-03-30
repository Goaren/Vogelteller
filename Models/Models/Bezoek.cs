using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    class Bezoek
    {
        private int id;
        private DateTime start;
        private DateTime einde;

        public int Id { get { return id; } set { id = value; } }
        public DateTime Start { get { return start; } set { start = value; } }
        public DateTime Einde { get { return einde; } set { einde = value; } }

        public Bezoek(int id, DateTime start, DateTime einde)
        {
            this.id = id;
            this.start = start;
            this.einde = einde;
        }
    }
}
