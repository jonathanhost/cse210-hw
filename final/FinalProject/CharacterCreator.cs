public class CharacterCreator:Character
{
  
    public void CreateKnight(string name){
      _name = name;
      _class = "Knight";
      _level = 1;
      _lifePoints = 40;
      _defencePoints = 16;
      _attackPoints = 8;
      _money = 2;
      _description = "A skilled and resilient fighter, specialized in close combat and the use of heavy weapons.";
    }

     public void CreateMage(string name){
      _name = name;
      _class = "Mage";
      _level = 1;
      _lifePoints = 10;
      _defencePoints = 5;
      _attackPoints = 5;
      _money = 10;
    }

     public void CreateArcher(string name){
      _name = name;
      _class = "Archer";
      _level = 1;
      _lifePoints = 15;
      _defencePoints = 15;
      _attackPoints = 4;
      _money = 4;
    }

    public void CreatePaladin(string name){
      _name = name;
      _class = "Archer";
      _level = 1;
      _lifePoints = 30;
      _defencePoints = 14;
      _attackPoints = 4;
      _money = 2;
    }

    public void CreateBard(string name){
      _name = name;
      _class = "Archer";
      _level = 1;
      _lifePoints = 25;
      _defencePoints = 17;
      _attackPoints = 5;
      _money = 4;
    }
  
}