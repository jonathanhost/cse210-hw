public class World
{
  private List<Enemie> _enemies = new List<Enemie>{};



  public List<Enemie> GetEnemies(){
    return _enemies;
  }
  public void Stage1()
  {
    Console.WriteLine("You embark on your journey in a tranquil and peaceful village, where suddenly the serenity is shattered by the presence of mysterious creatures that launch attacks on the unsuspecting residents. Amidst the chaos, you come face to face with a formidable adversary known as the Shadowclaws Soldier. Brace yourself, for a fierce battle lies ahead!");
    Console.WriteLine("\n\n\n\n\nPress Enter to Continue...");
    Console.ReadLine();
    
    Enemie _enemie = new Enemie( "Shadowclaws Soldier", 1, 35,15,6,20);
    _enemies.Add(_enemie);
  }

  public void Stage2()
  {
    Console.Clear();
    Console.WriteLine("You receive crucial information that a sorcerer is on a quest to obtain ancient, magical artifacts that bestow unimaginable powers. With this knowledge, you embark on a perilous quest to secure these artifacts before the villainous sorcerer. The stakes are high, as the sorcerer's possession of these artifacts would grant them immeasurable strength.");
    Console.WriteLine("\n\n\nYour journey takes you through treacherous dungeons, where you face daunting challenges, solve intricate puzzles, and vanquish formidable guardians. Your mission is clear: retrieve the artifacts before they fall into the wrong hands. However, as you progress, two relentless Shadowclaws Soldiers suddenly emerge, poised to attack. It's time to steel yourself and engage in a fierce battle to defend your mission and claim victory.");
    Console.WriteLine("\n\n\n\n\nPress Enter to Continue...");
    Console.ReadLine();
    _enemies.Clear();
    Enemie _enemie = new Enemie( "Shadowclaws Soldier", 1, 45,18,7,30);
    _enemies.Add(_enemie);
    Enemie _enemie2 = new Enemie( "Shadowclaws Soldier 2", 1, 45,18,6,30);
    _enemies.Add(_enemie2);
  }

  public void Stage3()
  {
    _enemies.Clear();
    Console.Clear();
    Console.WriteLine("As you delve deeper into your quest, you stumble upon an ancient prophecy that reveals your pivotal role in the imminent battle against the formidable Shadowclaws. The prophecy explicitly designates you as the sole beacon of hope, tasked with vanquishing these sinister foes and safeguarding the kingdom from their oppressive grasp.");
    Console.WriteLine("\n\n\nWith this newfound revelation, your senses heighten as you become acutely aware of the Shadowclaws soldiers closing in on you. Four of them emerge, their menacing presence demanding your immediate attention. Brace yourself, for a fierce battle awaits as you prepare to confront these relentless adversaries head-on.");
    Console.WriteLine("\n\n\n\n\nPress Enter to Continue...");
    Console.ReadLine();
    Enemie _enemie = new Enemie( "Shadowclaws Soldier", 2, 30,22,6,50);
    _enemies.Add(_enemie);
    Enemie _enemie2 = new Enemie( "Shadowclaws Soldier 2", 2, 30,18,8,45);
    _enemies.Add(_enemie2);
    Enemie _enemie3 = new Enemie( "Shadowclaws Soldier 3", 2, 40,22,7,20);
    _enemies.Add(_enemie3);
    Enemie _enemie4 = new Enemie( "Shadowclaws Soldier 4", 1, 30,22,6,20);
    _enemies.Add(_enemie4);
  }
  public void Stage4()
  {
    _enemies.Clear();
    Console.Clear();
    Console.WriteLine("At long last, you arrive at the formidable lair of the Shadowclaws, an ominous fortress brimming with treacherous traps and the devoted minions of the sorcerer. As you step foot into their lair, the Shadowclaws reveal their true powers, their malevolence palpable in the air, and they issue a direct challenge to you, the hero, for an epic showdown.");
    Console.WriteLine("\n\n\nHowever, as you advance deeper into the fortress, you encounter a daunting obstacle in your path. Two formidable Shadowclaws generals stand guard, fiercely protecting the access to the inner sanctum where the heart of the Shadowclaws resides. In order to proceed, you must face these powerful adversaries head-on and emerge victorious in this crucial encounter. Ready yourself, for the fate of your mission hinges on defeating these formidable foes and unlocking the path to the ultimate battle with the Shadowclaws.");
    Console.WriteLine("\n\n\n\n\nPress Enter to Continue...");
    Enemie _enemie = new Enemie( "Shadowclaws Capitan", 5, 60,23,9,40);
    _enemies.Add(_enemie);
    Enemie _enemie2 = new Enemie( "Shadowclaws Capitan 2", 5, 60,23,8,40);
    _enemies.Add(_enemie2);
  }

   public void Stage5()
   {
    _enemies.Clear();
    Console.Clear();
    Console.WriteLine("The long-awaited moment of the ultimate confrontation with the ShadowClaws has arrived. The destiny of the kingdom hangs in the balance, and the weight of the world rests upon your shoulders. In the face of overwhelming adversity, you must summon every ounce of strength, courage, and resilience to emerge triumphant over the villain.");
    Console.WriteLine("\n\n\nWith determination in your heart, you stand ready to confront the ShadowClaws head-on. The time for doubt has passed, as you bravely step forward to fulfill your destiny and safeguard the kingdom. It is through unwavering perseverance and unwavering resolve that you shall prevail against all odds, ensuring a brighter future for all.");
    Enemie _enemie = new Enemie( "Master of Shadows.", 10, 100,40,12,500);
    _enemies.Add(_enemie);
  }


}