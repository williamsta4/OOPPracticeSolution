using FantasyLibComposition;

namespace FantasyLibComposition
{
    public class Axe
    {
        public int Damage { get; set; } = 5;

        public void Hit (Monster monster, int  additionDamage)
        {
            monster.TakeDamage(Damage + additionDamage);
        }


        //No Arg Constructor ctor tab tab 
        public Axe(){}

        //Copy Constructor 
        public Axe(Axe copy) {Damage = copy.Damage;}

    }
}
