using FantasyLib;

namespace FantasyTesting
{
    [TestClass]

    public  class AMonster
    {

        [TestMethod]
        public void CanTakeDamage()
        {
            var sut = new Monster();
            sut.TakeDamage(5);
            Assert.AreEqual(95, sut.HP);

        }

        public void AttackWarrior()
        {
            var sut = new Monster();
            var warrior = new Warrior();

            sut.AttackWarrior(warrior);
            Assert.AreEqual(41, warrior.HP);
        }
    }
}
