using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralizedElections
{
    public class Candidate
    {
        private string candidateName;
        private int nrOfVotes;

        public Candidate(string candidateName, int nrOfVotes)
        {
            this.candidateName = candidateName;
            this.nrOfVotes = nrOfVotes;
        }
    }
}
