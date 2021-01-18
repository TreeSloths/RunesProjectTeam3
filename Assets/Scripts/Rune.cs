using UnityEngine;
using UnityEngine.UI;
public class Rune : MonoBehaviour{
   public ObjectTemplate runeTemplate;
   public Button button;
   public Text typeText;

   private void Start(){
      this.name = runeTemplate.name;
      this.button.GetComponent<Image>().color = runeTemplate.typeColor;
      this.typeText.text = runeTemplate.type;
   }
}
