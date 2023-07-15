public class Store
{
  private List<Item> _itens = new List<Item>{
  new Item("Elven Sword",1,3,5),
  new Item("Dragon Shield:",5,2,10),
  new Item("Ebony Bow",2,5,5),
  new Item("Platinum Armor",6,0,20),
  new Item("Staff of Serenity",5,2,10),
  new Item("Gloves of Dexterity",4,2,5),
  new Item("Amulet of Protection",7,0,15),
  new Item("Dark Dagger",1,7,15),
  new Item("Resistance Helmet",5,0,15),
  new Item("Ring of Power",6,6,10)};


 public void DisplayList(){
  Console.Clear();
  int count = 1;
  foreach(Item item in _itens){
    Console.WriteLine($"{count} - {item.DisplayItem()}\n");
    count++;
  }
 }
   public Item BuyItem(int choice){
    int itemchoice = choice - 1;
    return _itens[itemchoice];
   }
 
}