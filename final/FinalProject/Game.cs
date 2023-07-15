public class Game
{
  protected CharacterCreator _creator = new CharacterCreator(){};
  private List<Enemie> _enemies = new List<Enemie>{};
  protected World _word = new World();
  protected Store _store = new Store();
  
  public void DisplayLoad()
  {
  List<string> waitingCharacters = new List<string>();
   waitingCharacters.Add("|");
   waitingCharacters.Add("/");
   waitingCharacters.Add("-");
   waitingCharacters.Add("\\");
   waitingCharacters.Add("|");
   waitingCharacters.Add("/");
   waitingCharacters.Add("-");
   waitingCharacters.Add("\\");
   foreach(string s in waitingCharacters)
   {
      Console.Write(s);
      Thread.Sleep(500);
      Console.Write("\b \b");
   }
  }
  public void DiplayWelCome()
  {
    Console.Clear();
    Console.WriteLine($"\n\n\n\n O\n/|\\/\n/ \\\n======== Welcome to the RPG GAME");
  }
  public void DisplayMenu()
  {
    Console.Clear();
    Console.WriteLine($"RPG GAME MENU\n\n");
    Console.WriteLine($"Select the option\n");
    Console.WriteLine($"1. Start\n2. Quit");
  }
  public void DisplayAnimation()
  {
      Console.Write("");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
  }
  public void DisplayIntroduction()
  {       Console.Clear();
          Console.Write($"The heroes are summoned by a desperate king to retrieve the legendary Crown of Ascension, an ancient artifact that bestows immense power and reigns over the primordial elements. The Crown has been stolen by a notorious thieves' guild known as the Shadowclaws, who have hidden it in a treacherous dungeon filled with traps");
          DisplayAnimation();
          Console.Write("\n\nThe heroes' objective is to venture into the perilous dungeon, confront the followers of the Shadowclaws, and reclaim the Crown of Ascension. They must navigate dark halls and solve enigmatic puzzles, battle fierce monsters, and deactivate deadly traps");
          DisplayAnimation();
          Console.Write("\n\nAs they explore the dungeon, the heroes uncover that the Crown of Ascension is just a piece of a more sinister plan. A shadowy figure, known as the Master of Shadows, intends to use the Crown to unleash a storm of destruction upon the kingdom");
          DisplayAnimation();
          Console.Write("\n\nThe ultimate objective of the heroes is not only to recover the Crown of Ascension but also to thwart the Master of Shadows from realizing their malevolent scheme. They must confront the leader of the Shadowclaws and eventually face the Master of Shadows themselves in an epic battle to save the kingdom from ruin");
          DisplayAnimation();
          Console.WriteLine("\n\n\n\n\nPress Enter to Start!");
          Console.ReadLine();
          Console.Clear();

  }
  public void Displaycontent()
  {
    Console.Clear();
    Console.WriteLine($"Hello {_creator.GetName()}!\n");
    Console.WriteLine($"You are a {_creator.GetClass()}!");
    Console.WriteLine(_creator.GetDescription());
    Console.WriteLine("\n\n\n\n\nPress Enter to Continue!"); 
  }
  public void Start()
  {
    CreatorMenu();
    Displaycontent();
    Console.ReadLine();
    DisplayIntroduction();
    _word.Stage1();
    _enemies = _word.GetEnemies();
    Fight(_word.GetEnemies(),_creator);
    Console.ReadLine();
    _word.Stage2();
    _enemies = _word.GetEnemies();
    Fight(_word.GetEnemies(),_creator);
    Console.ReadLine();
     _word.Stage3();
    _enemies = _word.GetEnemies();
    Fight(_word.GetEnemies(),_creator);
    Console.ReadLine();
     _word.Stage4();
    _enemies = _word.GetEnemies();
    Fight(_word.GetEnemies(),_creator);
    Console.ReadLine();
     _word.Stage5();
    _enemies = _word.GetEnemies();
    Fight(_word.GetEnemies(),_creator);
    Console.ReadLine();
    GameEnd();
  }
  public void GameEnd()
  {
    Console.Clear();
    Console.WriteLine("Congratulations You Finished the Game!!!!!!!!!!!");
    Console.WriteLine("Now, the hero unleashes their true potential and, with courage and determination, defeats the villain, restoring peace and harmony to the realm.");
    Console.WriteLine("END...");
    DisplayLoad();
  }
  public void CreatorMenu()
  {
    Console.Clear();
    Console.WriteLine($"\n\nSelect the Character Class ");
    Console.WriteLine($"1. Knight \n2. Mage\n3. Archer\n4. Paladin\n5. Bard");
    string option = Console.ReadLine();
    CreateCharacter(option);
  }
  public void CreateCharacter(string option)
  {
    string name = UserName();
    if (option == "1")
    {
      _creator.CreateKnight(name);
    }
    else if (option == "2")
    {
      _creator.CreateMage(name);
    }
     else if (option == "3")
    {
      _creator.CreateArcher(name);
    }
     else if (option == "4")
    {
      _creator.CreatePaladin(name);
    }
     else if (option == "5")
    {
      _creator.CreateBard(name);
    }
  }
  public string UserName()
  {
    Console.Clear();
    Console.WriteLine($"Select the Character name: ");
    string name = Console.ReadLine();
    return name;
  }
  public void RunMenu()
  {
    string answer = "";
    while(answer != "3")
    {
      Console.WriteLine("1. Store\n2. Rest\n3. Return to Battle");
      answer = Console.ReadLine();
    if(answer == "1")
    {
      OpenStore();
    }
    else if (answer == "2")
    {
      Rest();
    }
    }
   

  }
  public void Rest()
  {
    Console.WriteLine("1. Rest 12 Hours ( 5 coins )\n2. Rest 24 Hours ( 10 coins )");
    string answer = Console.ReadLine();
    if(answer == "1")
    {
      if(_creator.GetMoney() > 5)
      {
        _creator.SetMoney(-5);
        _creator.SetlifePoints(15);
        Console.WriteLine("You rested 12 hours, you recovery 15 life points");
      }
      else
      {
        Console.WriteLine("You don't have sufficient coins");
      }
    }
    else if (answer == "2")
    {
      if(_creator.GetMoney() > 10)
      {
        _creator.SetMoney(-10);
        _creator.SetlifePoints(35);
        Console.WriteLine("You rested 24 hours, you recovery 35 life points");
      }
      else
      {
        Console.WriteLine("You don't have sufficient coins");
      }
    }
  }
  public void OpenStore()
  {
    Console.WriteLine("1. Buy Itens\n2. Quit");
    string answer = Console.ReadLine();
    if(answer == "1")
    {
    _store.DisplayList();
    string choice = Console.ReadLine();
    Item newitem = _store.BuyItem(int.Parse(choice));
      if(_creator.GetMoney() >= newitem.Getprice())
      {
        _creator.EquipItem(newitem);
        _creator.SetMoney(-newitem.Getprice());
      }
      else
      {
        Console.WriteLine($"Insuficient Founds, you have {_creator.GetMoney()}");
      }
    }
    else
    {
    }
  }
  public void GameOver()
  {
    Console.WriteLine("GAME OVER");
    Console.Write("You Was Defeated");
    DisplayAnimation();
    Console.WriteLine("");
    System.Environment.Exit(0);
  }
  public void Fight(List<Enemie> enemies , CharacterCreator hero)
{
  Console.WriteLine("The Battle Started!");
  foreach(Enemie enemy in enemies)
  {
    while(enemy.IsLive())
    {   
        Console.WriteLine();
        Console.WriteLine("Its Your turn:");
        Console.WriteLine("1. Attack\n2. Options");
        string choice = Console.ReadLine();
        Console.Clear();
        if(choice == "1")
        {
          hero.Attack(enemy);
        }
        else
        {
          RunMenu();
        }
        if(enemy.IsLive())
        {
          Console.WriteLine($"It's {enemy.GetName()} turn: \n");
          enemy.Attack(hero);
        }
        else{
          Console.WriteLine($"It's {enemy.GetName()} Defeted");
        }

        if(!hero.IsLive())
        {
          GameOver();
        }
      }
    }
    BattleWon();
  }
public void BattleWon(){
  Console.Clear();
  Console.WriteLine("Congratulations!!\n");
  
  Console.WriteLine("You Won the Battle!\n");
  _creator.RecieveMoney(); 
  Console.WriteLine("\nPress Enter to Continue");
  
}
}


