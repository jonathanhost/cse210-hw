public class CheckListGoal : Goal
{
  private int _bonus;
  private int _currentNumber = 0;
  private int _goalNumber; 

  public  CheckListGoal(string name, string description, int points, int bonus, int goal): base(name,description,points)
  {
    _bonus = bonus;
    _goalNumber = goal;
  }
  public CheckListGoal(string name, string description, int points, int bonus, int goal, int currentnumber): base(name,description,points)
  {
    _bonus = bonus;
    _goalNumber = goal;
    _currentNumber = currentnumber;
  }
  public Boolean IsComplete()
  {
    if(_currentNumber == _goalNumber)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
  public override string DisplayGoal()
  {
    if(_currentNumber == _goalNumber)
    {
      return $"[X] {_goalName}({_goalDescription}) -- Currently completed: {_currentNumber}/{_goalNumber}";
    }
    else
    {
      return $"[ ] {_goalName}({_goalDescription}) -- Currently completed: {_currentNumber}/{_goalNumber}";
    }  
  }
  public override void RecordEvent()
  {
    _currentNumber++;
    if(_currentNumber == _goalNumber)
    {
      AddBonus();
    }
  }
  public void AddBonus()
  {
    _goalPoint += _bonus;
  }
  public override string SaveGoal()
  {
    return $"ChecklistGoal:{_goalName},{_goalDescription},{_goalPoint},{_bonus},{_goalNumber},{_currentNumber}";
  }

}