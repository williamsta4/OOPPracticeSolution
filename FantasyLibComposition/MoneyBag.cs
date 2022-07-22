using FantasyLibComposition;
namespace FantasyLibComposition
{
    public class MoneyBag
    {
        //properties
        public int Gold { get; set; } = 0;
        public int Silver { get; set; } = 0;
        public int Copper { get; set; } = 0;
        //-------

        //constructors
        public MoneyBag() { } //default constructor
        public MoneyBag(int gold, int silver, int copper) //paramerized constructor
        {
            Gold = gold;
            Silver = silver;
            Copper = copper;
        
        } //paramerized constructor
        public MoneyBag(MoneyBag copy) //copy constructor 
        {
            Gold = copy.Gold;
            Silver = copy.Silver;
            Copper = copy.Copper;
        }
        //-------


        //to String 
        public override string ToString()
        {
            return "\nGold: " + Gold +"\tSilver: " + Silver + "\tCopper: " + Copper; 
        }

       public void update(int gold, int silver, int copper)
        {
            Gold += gold;
            Silver += silver;
            Copper += copper;

            if (Copper < 0) Copper = 0;
            if (Gold < 0) Gold = 0;
            if (Silver < 0) Silver = 0;

                

                
          
        }





    }
}