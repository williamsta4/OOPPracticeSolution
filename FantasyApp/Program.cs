using FantasyLib;

Dependancy();

 static void Dependancy()
{
    var warrior = new Warrior ();
    var axe = new Axe ();
    var monster = new Monster();



    Console.WriteLine("The Monster's starting HP is: " + monster.HP);//prints hp
    Console.WriteLine("The Warrior's starting HP is: " + warrior.HP); //prints hp


    Console.WriteLine("The Warrior attacks the monster with the axe!");

    warrior.AttackMonster(monster, axe); //warrior hits monster

    Console.WriteLine("The Monster's HP is now: " + monster.HP); //prints hp

    Console.WriteLine("The Warrior goes into a rage, his new strength is 5!");
    warrior.Strength = 5;//strength of warrior

    warrior.AttackMonster(monster, axe); //warrior hits monster
    Console.WriteLine("The Monster's HP is now: " + monster.HP); //prints hp

    monster.AttackWarrior(warrior);
    Console.WriteLine("The Monster hits the Warrior!");
    Console.WriteLine("The Warrior's HP is now: " + warrior.HP); //prints hp









}
