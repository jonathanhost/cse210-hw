public class Game  
{ 
  private User _user = new User();
  HandleFile _handleFile = new HandleFile();
  private string _userChoice = "";
  public void DisplayMenu()
  {  
    Console.WriteLine("");
    Console.WriteLine("Menu Options:");
    Console.WriteLine(" 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
    Console.WriteLine("Select a choice from the menu:");
    _userChoice = Console.ReadLine();
  }
  public void SetUserName(string name){
    _user.SetName(name);
  }
  public void DisplayCreateGoal()
  { 
    Console.Clear();
    Console.WriteLine("The types of Goals are");
    Console.WriteLine(" 1. Simple Goal\n 2. Eternal Goal\n 3. CheckList Goal\n");
    Console.WriteLine("Which type of goal would you like to create:");
    _userChoice = Console.ReadLine();
    CreateGoal();
  }
  public void SaveGoals()
  {
    Console.WriteLine("What is the file name? ");
    string filename = Console.ReadLine();
    _handleFile.SaveToFile(_user.GetList(),_user,filename);
  }
  public void LoadGoals()
  {
    Console.WriteLine("What is the file name? ");
    string filename = Console.ReadLine();
    _user = _handleFile.LoadToFile(filename);
  }
  public void CreateGoal()
  {  
    if (_userChoice == "1")
    {
      CreateSimpleGoal();
    } 
    else if (_userChoice == "2") 
    {
      CreateEternalGoal();
    }
    else if (_userChoice == "3") 
    {
      CreateCheckListGoal();
    } 
    else
    {
      Console.WriteLine("Invalid option! Try again");
    } 
  }
  public void CreateEternalGoal()
  { 
    Console.Clear();
    Console.WriteLine("What is the name of your goal? ");
    string name = Console.ReadLine();
    Console.WriteLine("What is a short description of it? ");
    string description = Console.ReadLine();
    Console.WriteLine("Which  is the amount of points associeated with this goal? ");
    string points_string = Console.ReadLine();
    int points = int.Parse(points_string);
    EternalGoal _eternalGoal = new EternalGoal(name,description,points);
    _user.AddGoal(_eternalGoal);
  }
  public void CreateCheckListGoal()
  {
    Console.Clear();
    Console.WriteLine("What is the name of your goal? ");
    string name = Console.ReadLine();
    Console.WriteLine("What is a short description of it? ");
    string description = Console.ReadLine();
    Console.WriteLine("Which  is the amount of points associeated with this goal? ");
    string points_string = Console.ReadLine();
    int points = int.Parse(points_string);
    Console.WriteLine("How many tmes does this goal need to be accomplished for a bonus? ");
    string bonus_time_string = Console.ReadLine();
    int bonus_time = int.Parse(bonus_time_string);
    Console.WriteLine("What is the bonus for accomplishing it that many times? ");
    string bonus_string = Console.ReadLine();
    int bonus = int.Parse(bonus_string);
    CheckListGoal _checkListGoal = new CheckListGoal(name,description,points,bonus,bonus_time);
    _user.AddGoal(_checkListGoal);
  }
  public void CreateSimpleGoal()
  { 
    Console.Clear();
    Console.WriteLine("What is the name of your goal? ");
    string name = Console.ReadLine();
    Console.WriteLine("What is a short description of it?");
    string description = Console.ReadLine();
    Console.WriteLine("Which is the amount of points associeated with this goal?");
    string points_string = Console.ReadLine();
    int points = int.Parse(points_string);
    SimpleGoal _simpleGoal = new SimpleGoal(name,description,points);
    _user.AddGoal(_simpleGoal);

  }
  public void DisplayPoints()
  { 
    Console.WriteLine($"Hello {_user.GetName()}, you have {_user.GetPoints()} points.");
  }
  public void SetUserChoice(string choice){
    _userChoice = choice;
  }
  public void ListGoals()
  {
    Console.Clear();
    Console.WriteLine("List of Goals:\n");
    int counter = 1;
    foreach(Goal goal in _user.GetList()){
    Console.WriteLine($"{counter}.{goal.DisplayGoal()}");
    counter++;
  }
  DisplayLoad();
}
  public void RecordEvent(){
    int counter = 1;
    foreach(Goal goal in _user.GetList())
    {
      Console.WriteLine($"{counter}.{goal.GetName()}");
      counter++;
    }
    Console.WriteLine($"Which goal did you accomplish?");
    string complete_string = Console.ReadLine();
    int complete = int.Parse(complete_string);
    CompleteGoal(complete);

  }
  public void CompleteGoal(int complete_number)
  {
    int counter = 1;
    foreach(Goal goal in _user.GetList())
    {
      if(counter == complete_number)
      {
        goal.RecordEvent();
        _user.SetPoints(goal.GetPoints());
        Console.WriteLine($"Congratulations! You have earned {goal.GetPoints()}");
        Console.WriteLine($"You now have {_user.GetPoints()}");
      }
      counter++;
    }
  }
  public string GetChoice()
  {
    return  _userChoice;
  }
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



}