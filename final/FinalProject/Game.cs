public class Game
{
  protected CharacterCreator _creator = new CharacterCreator(){};
  protected Character _user = new Character(){};
  private List<Enemie> _enemies = new List<Enemie>{};
  protected World _word = new World();
  
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
  public void DiplayWelCome(){
    Console.Clear();
    Console.WriteLine($"\n\n\n\n O\n/|\\/\n/ \\\n======== Welcome to the RPG GAME");
  }
  public void DisplayMenu(){
    Console.Clear();
    Console.WriteLine($"RPG GAME MENU\n\n");
    Console.WriteLine($"Select the option\n");
    Console.WriteLine($"1. Start \n2. Settings\n3. Quit");
  }
  public void DisplayAnimation(){
      Console.Write("");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
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
  public void Start(){
    CreatorMenu();
    displaycontent();
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

   
  }
  public void CreatorMenu(){
    Console.Clear();
    Console.WriteLine($"\n\nSelect the Character Class ");
    Console.WriteLine($"1. Knight \n2. Mage\n3. Archer\n4. Paladin\n5. Bard");
    string option = Console.ReadLine();
    CreateCharacter(option);
  }
  public void CreateCharacter(string option){
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
  public string UserName(){
    Console.Clear();
    Console.WriteLine($"Select the Character name: ");
    string name = Console.ReadLine();
    return name;
  }
  public void displaycontent(){

    Console.Clear();
    Console.WriteLine($"Hello {_creator.GetName()}!\n");
    Console.WriteLine($"You are a {_creator.GetClass()}!");
    Console.WriteLine(_creator.GetDescription());
    Console.WriteLine("\n\n\n\n\nPress Enter to Continue!");
    
  }
  public void GameOver(){
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
        Console.WriteLine("1. Attack\n2. Run");
        string choice = Console.ReadLine();
        Console.Clear();
        if(choice == "1")
        {
          hero.Attack(enemy);
        }
        else
        {
          break;
        }
        if(enemy.IsLive())
        {
          Console.WriteLine($"It's {enemy.GetName()} turn: ");
          enemy.Attack(hero);
        }

        if(!hero.IsLive())
        {
          GameOver();
        }
      }
    }
    Console.WriteLine($"You Won the Battle!\n Press Enter to Continue");
    Console.ReadLine();
  }
}



