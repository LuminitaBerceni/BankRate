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
        //private int index = 0;

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

        public bool GetNext(out Candidate candidate)
        {
            if (index < this.candidates.Length)
            {
                candidate = this.candidates[index++];
                return true;
            }
            candidate = null;
            return false;
        }

        public void SortCandidatesByVotes()
        {
            for (int i = 0; i < candidates.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (candidates[j - 1].HasMoreVotes(candidates[j]))
                        Swap(ref candidates[j - 1], ref candidates[j]);
                }
            }
        }

        /*public void HeapSort()
        {
            int n = candidates.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(n, i);
            }
            for (int i = n - 1; i >= 0; i--)
            {
                Swap(ref candidates[0], ref candidates[i]);

                Heapify(i, 0);
            }
        }

        private void Heapify(int n, int root)
        {
            int largest = root;
            int left = 2 * root + 1;
            int right = 2 * root + 2;

            if (left < n && candidates[left].HasMoreVotes(candidates[largest]))
            {
                largest = left;
            }
            if (right < n && candidates[right].HasMoreVotes(candidates[largest]))
            {
                largest = right;
            }
            if (largest != root)
            {
                Swap(ref candidates[root], ref candidates[largest]);
                Heapify(n, largest);
            }
        }*/

        private static void Swap(ref Candidate candidate1, ref Candidate candidate2)
        {
            var temp = candidate1;
            candidate1 = candidate2;
            candidate2 = temp;
        }

    }
}
