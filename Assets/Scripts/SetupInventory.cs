using UnityEngine;

public class SetupInventory : MonoBehaviour{
    public GameObject runePrefab;
    public RuneInventory runeInventory;
    private void Start(){
        runeInventory.AddFourRunes(); // just used for testing...
        foreach (var rune in runeInventory.ownedRunes){
            var instance = Instantiate(runePrefab, this.transform);
            // Setup runes? their rarity and their type?... instance.setup();
        }
    }
}
