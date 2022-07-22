using FantasyLibComposition;

namespace FantasyLibComposition
{
    public class Warrior
    {


        private Axe? _axe; //private 
        private MoneyBag _moneyBag;

        public MoneyBag MoneyBag 
        {
            get 
            {
                return new MoneyBag(_moneyBag);
            }
        }

        public Warrior(MoneyBag moneyBag)
        {
            _moneyBag = new MoneyBag(moneyBag);

        }


        public MoneyBag? SharedMoneyBag { get; set; }



       
       
        

        public void UpdateMoney(int gold, int silver, int copper)
        {
            _moneyBag.update(gold, silver, copper);
        }













        //AXE ---------------------------------

        public Axe Axe
        {
            get
            { return new Axe(_axe); }
        }


        public int HP { get; set; } = 50;
        public int Strength { get; set; } = 3; 

        public void AttackMonster(Monster monster)
        {
            if (_axe != null)
            {
                _axe.Hit(monster, Strength);
            }

            else
            {
                monster.TakeDamage(Strength);
            }
            
        }

        public void TakeDamage (int damage )
        {
            HP -= damage; 
        }

        public void EquipAxe (Axe axe )
        {
            _axe = new Axe(axe);    
        }
       
    }
}