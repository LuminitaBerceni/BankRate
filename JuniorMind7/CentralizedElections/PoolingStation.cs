using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralizedElections
{
    class PoolingStation
    {
        private string poolingStationName;
        private Candidate[] candidates;

        public PoolingStation(string poolingStationName, Candidate[] candidates)
        {
            this.poolingStationName = poolingStationName;
            this.candidates = candidates;
        }
    }
}
