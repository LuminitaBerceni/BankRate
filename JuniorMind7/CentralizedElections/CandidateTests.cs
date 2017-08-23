using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CentralizedElections
{
    [TestClass]
    public class CandidateTests
    {
        [TestMethod]
        public void CompareToTest()
        {
            var candidatePSD = new Candidate("B", 10);
            var candidatePNL = new Candidate("a", 5);
            Assert.IsTrue(candidatePNL.IsBefore(candidatePSD));
            Assert.IsFalse(candidatePSD.IsBefore(candidatePNL));
        }

        [TestMethod]
        public void HasMoreVotesTest()
        {
            var candidatePSD = new Candidate("B", 10);
            var candidatePNL = new Candidate("a", 15);
            Assert.IsTrue(candidatePNL.HasMoreVotes(candidatePSD));
            Assert.IsFalse(candidatePSD.HasMoreVotes(candidatePNL));
        }

        [TestMethod]
        public void AddVotesTest()
        {
            var candidatePSD = new Candidate("B", 10);
            var candidatePNL = new Candidate("a", 5);
            candidatePNL.AddVotes(new Candidate("a", 10));
            Assert.IsTrue(candidatePNL.HasMoreVotes(candidatePSD));
            Assert.IsFalse(candidatePSD.HasMoreVotes(candidatePNL));
            candidatePNL.AddVotes(candidatePSD);
            Assert.IsTrue(new Candidate("C", 16).HasMoreVotes(candidatePNL));
        }
    }
}
