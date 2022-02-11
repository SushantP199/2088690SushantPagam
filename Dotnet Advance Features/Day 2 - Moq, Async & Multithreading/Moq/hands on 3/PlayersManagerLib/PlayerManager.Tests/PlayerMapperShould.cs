using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using PlayersManagerLib;

namespace PlayerManager.Tests
{
    [TestFixture]
    public class PlayerMapperShould
    {

        [Test]
        public void Create_Empty_Test()
        {
            var mock = new Mock<IPlayerMapper>();
            Player player = Player.RegisterNewPlayer("PlayerMapperTest", mock.Object);
        }

        [Test]
        public void Create_AlreadyExists_InDB_Test()
        {
            var mock = new Mock<IPlayerMapper>();
            mock.Setup(x => x.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(false);
            Player p = Player.RegisterNewPlayer("PlayerManager", mock.Object);
        }

        [Test]
        public void CreatePlayer_DoesNotAlreadyExistInDB_Test()
        {
            var mock = new Mock<IPlayerMapper>();
            mock.Setup(x => x.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(false);
            Player player = Player.RegisterNewPlayer("Test", mock.Object);

            Assert.AreEqual("Test", player.Name);
            Assert.AreEqual(23, player.Age);
            Assert.AreEqual("India", player.Country);
            Assert.AreEqual(30, player.NoOfMatches);
        }
    }
}