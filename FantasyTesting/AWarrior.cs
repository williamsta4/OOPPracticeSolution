
using FantasyLib;

namespace FantasyTesting
{
    [TestClass]
    public class AWarrior
    {
        [TestMethod]
        public void CanAttackAMonsterWithAnAxe()
        {
            var sut = new Warrior();
            var axe = new Axe();
            var monster = new Monster();

            sut.AttackMonster(monster, axe);

            Assert.AreEqual(92, monster.HP);
        }


        [TestMethod]
        public void CanTakeDamage()
        {
            var sut = new Warrior();
            sut.TakeDamage(9);
            Assert.AreEqual(41, sut.HP);

        }

    }
}