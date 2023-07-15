public class Item
{
  private string _name;
  private int _defencePoints;
  private int _attackPoints;
  private int _price;

   public Item( string name, int defencePoints, int attackPoints, int price)
   {
    _name = name;
    _defencePoints = defencePoints;
    _attackPoints = attackPoints;
    _price = price;
   }
   public string DisplayItem()
   {
    return $"{_name}(A:+{_attackPoints} D:+{_defencePoints}) - {_price}";
   }

   public int GetDefencePoints()
   {
    return _defencePoints;
   }

   public int GetAttackPoints()
   {
    return _attackPoints;
   }
   public int Getprice()
   {
    return _price;
   }
}