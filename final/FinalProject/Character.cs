public class Character
{
  protected string _name;
  protected string _class;
  protected int _level;
  protected int _lifePoints;
  protected int _defencePoints;
  protected int _attackPoints;
  protected int _money;
  protected string _description;
  protected Weapon _weapon;

  protected Random random = new Random();

public Character(){
   
  }
  public Character(string name, int level, int lifePoints,int defencePoints,int attackPoints){
    _name = name;
    _level = level;
    _lifePoints = lifePoints;
    _defencePoints = defencePoints;
    _attackPoints = attackPoints;
  }
  public string GetName(){
    return _name;
  }
   public string GetClass(){
    return _class;
  }
    public string GetDescription(){
    return _description;
  }

  public void Damage(int damage){
    _lifePoints -= damage;
  }
   public int GetLifePoints(){
    return _lifePoints;
  }

  public int GetDefencePoints(){
    return _defencePoints;
  }
  public void Attack(Character enemy)
    {
        Console.WriteLine($"{GetName()} is attacking {enemy.GetName()}!");
        int rolladie = random.Next(0, 19);
        int attackPower = _attackPoints + rolladie;
        int damage = 0;
        Console.WriteLine($"The attack power is {attackPower}!\n");
        if(attackPower > enemy.GetDefencePoints())
        { 
          Console.WriteLine("The attack Was Sucessfull");
          damage = attackPower - enemy.GetDefencePoints();
          enemy.Damage(damage);
          Console.WriteLine($"\n{enemy.GetName()} lost {damage} health points. Current health: {enemy.GetLifePoints()}");
        }
        else{
           Console.WriteLine("The attack failed");
        }
        
        Console.WriteLine();
    }
  public void Run(){
    
  }
  public void SetMoney(){
    
  }

  public Boolean IsLive(){
    if(_lifePoints > 0){
      return true;
    }
    else{
      return false;
    }
  }
}