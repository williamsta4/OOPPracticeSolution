
using FantasyLibComposition;

namespace FantasyTesting
{
    [TestClass]
    public  class AnotherWarrior
    {
        [TestMethod]
        public void CanAttackAMonsterWithoutAnAxe ()
        {
            var sut = new Warrior(new MoneyBag());
            var monster = new Monster();

            sut.AttackMonster(monster);
            Assert.AreEqual(97, monster.HP);

        }


        [TestMethod]
        public void CanAttackAMonsterWithAnAxe ()
        {
            var sut = new Warrior(new MoneyBag());
            var monster = new Monster();
            var axe = new Axe();

            sut.EquipAxe(axe);
            sut.AttackMonster(monster);
            Assert.AreEqual(92, monster.HP);



        }
    }
}
