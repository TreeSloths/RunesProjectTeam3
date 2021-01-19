using UnityEngine;

public class CreateRunes : MonoBehaviour{
    public RuneTypeList runeTypeList;
    public RarityTypesList rarityTypesList;
    public RuneInventory runeInventory;
    public int amountOfRunesToCreate;
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
    public void MergeRunes(Rune[] runes, int amount){
        if (amount == 2){
            // 20 % chance for upgraded rarity
        }
        if (amount == 3){
            // 55 % chance for upgraded rarity
        }
        if (amount == 4){
            // 95 % chance for upgraded rarity
        }
    }
}