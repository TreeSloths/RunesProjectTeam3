using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Rune2{
   public string runeType;
   public string rarity;
   public int amountOwned;
   public Rune2(string runeType, string rarity){
      this.runeType = runeType;
      this.rarity = rarity;
   }
}
