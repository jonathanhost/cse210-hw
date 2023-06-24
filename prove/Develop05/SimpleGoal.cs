public class SimpleGoal : Goal
{
private Boolean _complete = false;
public  SimpleGoal(string name, string description, int points): base(name,description,points)
{

}
public  SimpleGoal(string name, string description, int points, Boolean complete): base(name,description,points)
{
 _complete = complete;
}

public override void RecordEvent(){
  _complete = true;
}

public override string DisplayGoal(){

  if(_complete){
  return $"[X] {_goalName}({_goalDescription})";
  }else
  {
  return $"[ ] {_goalName}({_goalDescription})";
  }
 
}

public override string SaveGoal(){
 return $"SimpleGoal:{_goalName},{_goalDescription},{_goalPoint},{_complete}";
}


}