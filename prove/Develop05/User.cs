public class User  
{
  protected string _name;
  protected int _points = 0;
 protected List<Goal> _goalList = new List<Goal> {};

  public User(string name)
  {
    _name = name;
  }

   public User()
  {
    _name = "Undefined";
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