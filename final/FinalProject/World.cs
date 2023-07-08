public class World
{
  private List<Enemie> _enemies = new List<Enemie>{};



  public List<Enemie> GetEnemies(){
    return _enemies;
  }
  public void Stage1(){
    Console.WriteLine("Our hero begins his journey in a small peaceful village, where tranquility is suddenly disrupted by mysterious creatures that start attacking the residents. Prepare to Fight!");
    Console.WriteLine("\n\n\n\n\nPress Enter to Start!");
    Console.ReadLine();
    
    Enemie _enemie = new Enemie( "Shadowclaws Soldier", 1, 35,15,6,20);
    _enemies.Add(_enemie);
  }

  public void Stage2(){
    Console.Clear();
    Console.WriteLine("The hero receives information that the sorcerer is in search of ancient magical artifacts that grant unparalleled powers. The hero embarks on a quest to find these artifacts before the villain, knowing that if the sorcerer obtains them, their strength will become immeasurable. In this phase, the hero faces challenges in dangerous dungeons, solves puzzles, and defeats guardians to retrieve the artifacts before they fall into the wrong hands. Two Shadowclaws Soldiers are attacking you, it's time to fight!");
    Console.WriteLine("\n\n\n\n\nPress Enter to Start!");
    Console.ReadLine();
    _enemies.Clear();
    Enemie _enemie = new Enemie( "Shadowclaws Soldier", 1, 45,18,7,30);
    _enemies.Add(_enemie);
    Enemie _enemie2 = new Enemie( "Shadowclaws Soldier", 1, 45,18,6,30);
    _enemies.Add(_enemie2);
  }

  public void Stage3(){
    _enemies.Clear();
    Enemie _enemie = new Enemie( "Shadowclaws Soldier", 2, 70,22,6,50);
    _enemies.Add(_enemie);
    Enemie _enemie2 = new Enemie( "Shadowclaws Soldier", 2, 65,18,5,45);
    _enemies.Add(_enemie2);
    Enemie _enemie3 = new Enemie( "Shadowclaws Soldier", 2, 10,7,7,20);
    _enemies.Add(_enemie3);
    Enemie _enemie4 = new Enemie( "Shadowclaws Soldier", 1, 10,7,6,20);
    _enemies.Add(_enemie4);
  }
  public void Stage4(){
    _enemies.Clear();
    Enemie _enemie = new Enemie( "Shadowclaws Capitan", 5, 10,8,9,40);
    _enemies.Add(_enemie);
    Enemie _enemie2 = new Enemie( "Shadowclaws Capitan", 5, 10,8,8,40);
    _enemies.Add(_enemie2);
  }

   public void Stage5(){
    _enemies.Clear();
    Enemie _enemie = new Enemie( "Master of Shadows.", 10, 100,10,10,500);
    _enemies.Add(_enemie);
  }


}