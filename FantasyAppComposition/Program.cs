

using FantasyLibComposition;




var warrior = new Warrior(new MoneyBag());
var monster = new Monster();


Console.WriteLine("The Monster's starting HP is: " + monster.HP);//prints hp
Console.WriteLine("The Warrior's starting HP is: " + warrior.HP); //prints hp


Console.WriteLine("The Warrior melees the monster!");
warrior.AttackMonster(monster); //warrior hits monster
Console.WriteLine("The Monster's HP is now: " + monster.HP); //prints hp

monster.AttackWarrior(warrior);
Console.WriteLine("The Monster hits the Warrior!");
Console.WriteLine("The Warrior's HP is now: " + warrior.HP); //prints hp




var warrior2 = new Warrior(new MoneyBag());
var axe = new Axe();
var monster2 = new Monster();

Console.WriteLine("The Monster's starting HP is: " + monster2.HP);//prints hp
Console.WriteLine("The Warrior's starting HP is: " + warrior2.HP); //prints hp
Console.WriteLine("The Warrior finds an axe lying on the ground. It gives 5 HP!");
warrior2.EquipAxe(axe);

Console.WriteLine("The Warrior attacks the monster with an axe!");
warrior2.AttackMonster(monster2); //warrior hits monster
Console.WriteLine("The Monster's HP is now: " + monster2.HP); //prints hp

monster2.AttackWarrior(warrior2);
Console.WriteLine("The Monster hits the Warrior!");
Console.WriteLine("The Warrior's HP is now: " + warrior2.HP); //prints hp






var moneyBag = new MoneyBag(2, 3, 10);
var moneyBag2 = new MoneyBag(0, 20, 3);



Console.WriteLine("Here");
Console.WriteLine(moneyBag);
Console.WriteLine(moneyBag2);

//Diana-----
var diana = new Warrior(moneyBag);
Console.WriteLine(diana.MoneyBag);
//---------

//Xena-----
var xena = new Warrior(moneyBag);
Console.WriteLine(xena.MoneyBag);
//---------

//Xena-----
var artemis = new Warrior(moneyBag);
Console.WriteLine(artemis.MoneyBag);
//---------

diana.SharedMoneyBag = moneyBag2;
xena.SharedMoneyBag = moneyBag2;
artemis.SharedMoneyBag = moneyBag2;






