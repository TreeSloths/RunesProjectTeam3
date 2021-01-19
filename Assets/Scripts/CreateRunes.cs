using UnityEngine;

public class CreateRunes : MonoBehaviour{
    public RuneTypeList runeTypeList;
    public RarityTypesList rarityTypesList;
    public RuneInventory runeInventory;
    public int amountOfRunes;
    private void Start(){
        for (int i = 0; i < amountOfRunes; i++){
            runeInventory.AddRune(new Rune(runeTypeList.RandomRuneType(), rarityTypesList.RandomRarity()));
        }
    }
}