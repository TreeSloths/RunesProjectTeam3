using System.Collections.Generic;
using UnityEngine;

public class CreateRunes : MonoBehaviour{
    public RuneInventory runeInventory;
    public int amountOfRunesToCreate;

    public GameObject mergePanel;
    private bool sameType;
    public GameObject[] merginRunes;

    private void CreateNewRune(RuneType runeType, Rarity rarity){
        runeInventory.AddRune(new Rune(runeType, rarity,1));
    }
    private void CreateFourNewRunes(){
        for (int i = 0; i < amountOfRunesToCreate; i++){
            runeInventory.AddRune(new Rune(RuneTypeList.RandomRuneType(), new Rarity("Common"),1));
        }
    }
    
    public void MergeRunes() { 
        var chance = Random.Range(1, 100);
        var amount = mergePanel.transform.childCount;
        
        if (amount == 2 && chance > 80) {
            //Invoke event
            Debug.Log("Got an upgraded card with 2 cards");
            // 20 % chance for upgraded rarity
        }
        if (amount == 3 && chance > 45) {
            //Invoke event
            Debug.Log("Got an upgraded card upgraded with 3 cards");
            // 55 % chance for upgraded rarity
        }
        if (amount == 4 && chance > 5){
            //Invoke event
            Debug.Log("Got an upgraded card upgraded with 4 cards");
            // 95 % chance for upgraded rarity
        }
        else {
            return;
        }
        
    }

    private bool TypeCheck() {
        Rune mergingRunes = gameObject.GetComponentInChildren<Rune>();
        return false;
    } 
}