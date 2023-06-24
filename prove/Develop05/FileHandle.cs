public class HandleFile{

  public void SaveToFile(List<Goal> _goalsList,User _user,string filename)
  {
    using (StreamWriter outputFile = new StreamWriter(filename))
    {    
      outputFile.WriteLine($"{_user.GetPoints()}-{_user.GetName()}");
      foreach (Goal _goal in _goalsList)
      {  
        outputFile.WriteLine(_goal.SaveGoal());
      }
    }
  }    
  public User LoadToFile(String filename)
  {
    string[] lines = System.IO.File.ReadAllLines(filename);
    
    string[] user = lines[0].Split("-");
    int points = int.Parse(user[0]);
    string userName =user[1];
    User _user = new User(userName,points);
    foreach (string line in lines.Skip(1))
    {       
      string[] break_line = line.Split(":");
      string type = break_line[0];
      string[] goal_content = break_line[1].Split(",");
      if(type =="SimpleGoal")
      {
        int points_simple = int.Parse(goal_content[2]);
        Boolean complete = bool.Parse(goal_content[3]);
        SimpleGoal _simpleGoal = new SimpleGoal(goal_content[0],goal_content[1],points_simple,complete);
        _user.AddGoal(_simpleGoal);
      }
      else if(type =="EternalGoal")
      {
        int points_simple = int.Parse(goal_content[2]);
        EternalGoal _eternalgoal = new EternalGoal(goal_content[0],goal_content[1],points_simple);
        _user.AddGoal(_eternalgoal);
      }
      else
      {
        int points_checklist = int.Parse(goal_content[2]);
        int bonus = int.Parse(goal_content[3]);
        int goal = int.Parse(goal_content[4]);
        int current_number = int.Parse(goal_content[5]);
        CheckListGoal _checkListgoal = new CheckListGoal(goal_content[0],goal_content[1],points_checklist,bonus,goal,current_number);
        _user.AddGoal(_checkListgoal);
      }
    }
      return _user;
  }
}
    
    