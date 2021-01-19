using UnityEngine;
using UnityEngine.UI;
public class Rune{
   public RuneType runeType;
   public Rarity rarity;
   public int amountOwned;
   public Rune(RuneType runeType, Rarity rarity){
      this.runeType = runeType;
      this.rarity = rarity;
   }
}