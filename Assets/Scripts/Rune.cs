using UnityEngine;
using UnityEngine.UI;
public class Rune : MonoBehaviour{
   public ObjectTemplate runeTemplate;
   public Button button;
   public Text rarityTypeText;
   public Text amountText;
   private void Awake(){
      this.name = runeTemplate.name;
      this.button.GetComponent<Image>().color = runeTemplate.typeColor;
      this.rarityTypeText.text = runeTemplate.rarity;
      this.amountText.text = runeTemplate.amount.ToString();
   }
}
