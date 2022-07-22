using FantasyLibComposition;

namespace FantasyLibComposition
{
    public class Monster
    {
        public int HP { get; set; } = 100;
        public int Strength { get; set; } = 9;

        public void TakeDamage(int damage)
        {
            HP -= damage; 
        }

        public void AttackWarrior(Warrior warrior )
        {
            warrior.HP -= Strength; 
        }
    }
}
