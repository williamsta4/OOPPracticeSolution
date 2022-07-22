using FantasyLib;

namespace FantasyTesting
{
    [TestClass]
    public class AnAxe
    {
        [TestMethod]
        public void CanHitAMonster()
        {
            var sut = new Axe();
            var monster = new Monster();

            sut.Hit(monster, 5);
            Assert.AreEqual(90, monster.HP);



        }
    }
}
