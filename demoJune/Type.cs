using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoJune
{
    public partial class Agent
    {
        ProizvodstvoEntities proizvodstvoEntities = new ProizvodstvoEntities();
        public string nameType
        {
            get { return proizvodstvoEntities.TipAgenta.ToList().
               Where(f => f.TipAgentaId == this.TipAgentaId).FirstOrDefault().Nazvatie;
            }
            set { }
        }
    }
}
