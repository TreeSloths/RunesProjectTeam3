using UnityEngine;

public class CreateRunes : MonoBehaviour{
    public RuneTypeList runeTypeList;
    public RarityTypesList rarityTypesList;
    public RuneInventory runeInventory;
    public int amountOfRunesToCreate;
    
    private bool sameType;
    private GameObject firstRune;
    private GameObject secondRune;
    private GameObject thirdRune;
    private GameObject forthRune;
    private void CreateNewRune(RuneType runeType, Rarity rarity){
        runeInventory.AddRune(new Rune(runeType, rarity,1));
    }
    private void CreateFourNewRunes(){
        for (int i = 0; i < amountOfRunesToCreate; i++){
            runeInventory.AddRune(new Rune(runeTypeList.RandomRuneType(), new Rarity("Common"),1));
        }
    }
    // Merging runes needs to be same color/type
    // Needs to take the list of added runes in the merge slots.
    // Need a ref to merge slots?
    // dropped rune in one slot adds to list
    // if rune is picked up from slot then remove rune from list
    public void MergeRunes(Rune[] runes, int amount) {
        var chance = Random.Range(1, 100);

        if (amount == 2 && !TypeCheck()) {
            if (chance > 80) {
                //Invoke event
                Debug.Log("Got an upgraded card with 2 cards");
            }
            // 20 % chance for upgraded rarity
        }
        if (amount == 3 && !TypeCheck()) {
            if (chance > 45) {
                //Invoke event
                Debug.Log("Got an upgraded card upgraded with 3 cards");
            }
            // 55 % chance for upgraded rarity
        }
        if (amount == 4 && !TypeCheck()){
            if (chance > 5) {
                //Invoke event
                Debug.Log("Got an upgraded card upgraded with 4 cards");
            }
            // 95 % chance for upgraded rarity
        }
    }

    private bool TypeCheck() {
        if (firstRune.GetComponent<Rune>().runeType == secondRune.GetComponent<Rune>().runeType) {
            return true;
        } 
        return false;
    }
}