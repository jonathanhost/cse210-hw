public class User  
{
  protected string _name;
  protected int _points = 0;
 protected List<Goal> _goalList = new List<Goal> {};

 public User(string name, int points)
  {
    _name = name;
    _points = points;
  }
     public User()
  {
    _name = "Undefined";
  }
  public string GetName()
  {
    return _name;
  }

 public void SetPoints(int points)
 {
      _points+=points;
 }
  public int GetPoints()
 {
      return _points;
 }

  public void SetName(string name)
 {
     _name = name;
 }
  public void AddGoal(Goal goal)
 {
     _goalList.Add(goal);
 }

 public List<Goal> GetList(){
  return _goalList;
 }
}