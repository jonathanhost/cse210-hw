public class Enemie: Character
{
  
    private int _xpPoints;

 public Enemie(string name, int level, int lifePoints,int defencePoints,int attackPoints, int xpPoints):base( name,level,lifePoints, defencePoints, attackPoints){
    _xpPoints = xpPoints;

 }
  
}