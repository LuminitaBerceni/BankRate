using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CentralizedElections
{
    [TestClass]
    public class PollingStationTests
    {
        [TestMethod]
        public void AddVotesTest()
        {
            var candidatePSD = new Candidate("B", 10);
            var candidatePNL = new Candidate("a", 5);

            var candidatePSD1 = new Candidate("B", 20);
            var candidatePNL2 = new Candidate("a", 26);

            var central = new PollingStation("central", new Candidate[] { candidatePSD, candidatePNL });
            var local = new PollingStation("local", new Candidate[] { candidatePSD1, candidatePNL2 });
            central.AddVotes(local);
            Assert.IsFalse(candidatePSD.HasMoreVotes(candidatePNL));
        }

        [TestMethod]
        public void SortVotesTest()
        {
            var central = new PollingStation("central", new Candidate[] { new Candidate("PSD", 10), new Candidate("PNL", 20), new Candidate("PD", 15) });
            var local1 = new PollingStation("local1", new Candidate[] { new Candidate("PSD", 30), new Candidate("PNL", 15), new Candidate("PD", 15) });
            var local2 = new PollingStation("local2", new Candidate[] { new Candidate("PSD", 10), new Candidate("PNL", 25), new Candidate("PD", 20) });

            var expected = new PollingStation("central", new Candidate[] { new Candidate("PNL", 60), new Candidate("PSD", 50), new Candidate("PD", 50) });

            central.AddVotes(local1);
            central.AddVotes(local2);
            central.SortCandidatesByVotes();

            //Candidate candidate;
            //Assert.IsTrue(central.GetNext(out candidate));
            Assert.AreEqual(expected, central);

        }
    }
}
