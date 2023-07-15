public class CharacterCreator:Character
{
  
  public void CreateKnight(string name)
  {
    _name = name;
    _class = "Knight";
    _level = 1;
    _lifePoints = 40;
    _defencePoints = 20;
    _attackPoints = 6;
    _money = 15;
    _description = "The warrior or knight class excels in close combat and possesses high physical strength and durability. They are often equipped with heavy armor and powerful weapons, making them formidable front-line fighters and protectors.";
  }

     public void CreateMage(string name)
     {
      _name = name;
      _class = "Mage";
      _level = 1;
      _lifePoints = 10;
      _defencePoints = 20;
      _attackPoints = 5;
      _money = 15;
      _description = "Mages or wizards are masters of arcane magic and possess a wide range of spellcasting abilities. They can manipulate the elements, cast devastating offensive spells, and provide powerful support or defensive magic. Mages usually have lower physical defenses but compensate with their vast magical arsenal.";
    }

     public void CreateArcher(string name)
     {
      _name = name;
      _class = "Archer";
      _level = 1;
      _lifePoints = 15;
      _defencePoints = 20;
      _attackPoints = 6;
      _money = 15;
      _description = "Archers or rangers are skilled marksmen with a mastery of ranged weapons, such as bows or crossbows. They possess exceptional accuracy and agility, allowing them to strike enemies from a distance. Rangers often have additional abilities related to tracking, survival, and animal companions.";
    }

    public void CreatePaladin(string name)
    {
      _name = name;
      _class = "Archer";
      _level = 1;
      _lifePoints = 30;
      _defencePoints = 18;
      _attackPoints = 4;
      _money = 15;
      _description = "Paladins are holy knights who combine the skills of a warrior with the divine powers of a cleric. They possess a balance of combat prowess and healing abilities. Paladins often uphold a strict code of honor and righteousness, using their powers to protect the innocent and smite evil.";
    }

    public void CreateBard(string name)
    {
      _name = name;
      _class = "Archer";
      _level = 1;
      _lifePoints = 25;
      _defencePoints = 17;
      _attackPoints = 5;
      _money = 15;
      _description = "Bards are versatile performers who utilize music, poetry, or storytelling to weave powerful magic and inspire their allies. They have the ability to buff their teammates, debuff enemies, and even perform spells through their artistic expressions. Bards often possess a wide range of skills and can adapt to various situations.";
    }
  
}