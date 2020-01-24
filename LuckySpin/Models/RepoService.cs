using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckySpin.Models
{
    public class RepoService
    {
        private List<Spin> spins = new List<Spin>();
        public IEnumerable<Spin> Spins
        {
            get
            {
                return spins;
            }
        }
        public void AddSpin(Spin spin)
        {
            spins.Add(spin);
        }

    }
}
