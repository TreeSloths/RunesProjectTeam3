using UnityEngine;
using UnityEngine.UI;

public class SetupInventory : MonoBehaviour{
    public GameObject runePrefab;
    public RuneInventory runeInventory;
    private void Awake(){
        runeInventory.AddFourRunes(); // just used for testing...
    }
    private void Start(){
        foreach (Rune rune in runeInventory.ownedRunes){
            var instance = Instantiate(runePrefab, this.transform, true);
            instance.GetComponent<Button>().image.color = rune.runeType.typeColor;
            Transform childOne = instance.transform.GetChild(0);
            Transform childTwo = instance.transform.GetChild(1);
            Transform childThree = instance.transform.GetChild(2);
            childOne.GetComponent<Text>().text = rune.rarity.rarity;
            childTwo.GetComponent<Text>().text = rune.runeType.runeType;
            childThree.GetComponentInChildren<Text>().text = rune.AmountOwned.ToString();
        }
    }
    public void UpdateRunes(Rune rune){
        // update the rune
    }
}
