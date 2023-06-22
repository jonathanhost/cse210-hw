public class EternalGoal : Goal
{
  public  EternalGoal(string name, string description, int points): base(name,description,points){}
  public override string SaveGoal()
  {
  return $"EternalGoal:{_goalName},{_goalDescription},{_goalPoint}";
  }
}