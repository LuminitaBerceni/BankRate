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

        internal bool IsBefore(Candidate otherCandidate)
        {
            return string.Compare(candidateName, otherCandidate.candidateName) == -1;
        }

        internal bool HasMoreVotes(Candidate otherCandidate)
        {
            return nrOfVotes > otherCandidate.nrOfVotes;
        }

        internal void AddVotes(Candidate candidate)
        {
            if (string.Compare(candidateName, candidate.candidateName) == 0)
                nrOfVotes += candidate.nrOfVotes;
        }

        public bool IsSameCandidate(string name)
        {
            return candidateName.Equals(name);
        }

        public bool IsSameCandidate(Candidate other)
        {
            return candidateName.Equals(other.candidateName);
        }
    }
}
