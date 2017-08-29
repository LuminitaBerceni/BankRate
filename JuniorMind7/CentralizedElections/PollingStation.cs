using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralizedElections
{
    class PollingStation 
    {
        private string poolingStationName;
        private Candidate[] candidates;

        public PollingStation(string poolingStationName, Candidate[] candidates)
        {
            this.poolingStationName = poolingStationName;
            this.candidates = candidates;
        }

        internal void AddVotes(PollingStation local)
        {
            foreach (var candidate in candidates)
                foreach (var other in local.candidates)
                    candidate.AddVotes(other);
       
        }

        public void AddVotes(IEnumerable<PollingStation> stations)
        {
            foreach (var station in stations)
                AddVotes(station);
        }

        public void SortCandidatesByVotes()
        {
            for (int i = 0; i < candidates.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (candidates[j].HasMoreVotes(candidates[j - 1]))
                        Swap(ref candidates[j - 1], ref candidates[j]);
                }
            }
        }

        private static void Swap(ref Candidate candidate1, ref Candidate candidate2)
        {
            var temp = candidate1;
            candidate1 = candidate2;
            candidate2 = temp;
        }

    }
}
