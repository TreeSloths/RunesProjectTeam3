using System;
using UnityEngine;
using UnityEngine.UI;
public class Rune : MonoBehaviour{
   public ObjectTemplate runeTemplate;
   public Button button;
   public Text typeText;
   public Text rarityText;

   private void Awake(){
      this.name = runeTemplate.name;
      this.button.GetComponent<Image>().color = runeTemplate.typeColor;
      this.typeText.text = runeTemplate.type;
      //this.rarityText.text = runeTemplate.rarityLevel.ToString(); needs a text component on coming prefab..
   }
}
