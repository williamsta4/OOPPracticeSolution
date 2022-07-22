using FantasyLib;

namespace FantasyLib
{
    public class Warrior
    {
        public int HP { get; set; } = 50;
        public int Strength { get; set; } = 3; 

        public void AttackMonster(Monster monster, Axe axe)
        {
            axe.Hit(monster, Strength);
        }

        public void TakeDamage (int damage )
        {
            HP -= damage; 
        }
    }
}