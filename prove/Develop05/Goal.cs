public class Goal  
{ 
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoint;


  public Goal(string name, string description, int points)
  {
    _goalName = name;
    _goalDescription = description;
    _goalPoint = points;
  }
  public virtual void RecordEvent(){}
  
  public virtual string DisplayGoal()
  {
    return $"[ ] {_goalName}({_goalDescription})";
  }
  public virtual string SaveGoal()
  {
    return $"Goal:{_goalName},{_goalDescription},{_goalPoint}";
  }
  public string GetName()
  {
    return _goalName;
  }
  public int GetPoints()
  {
    return _goalPoint;
  }
  public string GetDescription()
  {
    return _goalDescription;
  }
  public void SetPoint(int points)
  {
    _goalPoint = points;
  }
}