using FantasyLibComposition;


var warrior = new Warrior();
var monster = new Monster();



var moneyBag = new MoneyBag(2, 3, 10);
var moneyBag2 = new MoneyBag(0, 20, 3);

var diana = new Warrior();
var xena = new Warrior();
var artemis = new Warrior();


//moneyBag2 = Warrior.SharedMoneyBag;
Console.WriteLine(moneyBag);
Console.WriteLine(moneyBag2);

Console.WriteLine(diana.MoneyBag);
diana.MoneyBag.Gold = 5;






var warrior = new Warrior();
var monster = new Monster();
