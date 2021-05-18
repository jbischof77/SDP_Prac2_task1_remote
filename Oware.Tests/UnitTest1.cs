using NUnit.Framework;

namespace Oware.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void ResetHouseRestoresHouseToTheSameState()
        {
            //ARRANGE
            House h = new House(0, 0);
            for (int i = 0; i < 16; i++)
            {
                h.AddSeedInPot(new Seed());
            }
            //ACT
            h.ResetHouse();
            //ASSERT
            Assert.AreEqual(4, h.GetCount());
        }

        [Test]
        public void AddSeedToScoreCallsAddSeed()
        {
            //ARRANGE
            Mock<ScoreHouse> sch = new Mock<ScoreHouse>();
            Player player = new Player("Jonah");
            //ACT
            sch.Setup(x => x.AddSeed(new Seed()));
            player.AddSeedToScoreHouse(new Seed());
            //ASSERT
            sch.VerifyAll();
        }
    }
}