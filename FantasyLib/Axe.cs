using FantasyLib;

namespace FantasyLib
{
    public class Axe
    {
        public int Damage { get; set; } = 5;

        public void Hit (Monster monster, int  additionDamage)
        {
            monster.TakeDamage(Damage + additionDamage);
        }
    }
}
