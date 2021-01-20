using System.Collections.Generic;
using UnityEngine;

public class RuneInventory : MonoBehaviour{
    public event System.Action<Rune> RuneAdded;
    public List<Rune> ownedRunes = new List<Rune>();
    public void AddRune(Rune rune){
        this.ownedRunes.Add(rune);
        this.RuneAdded?.Invoke(rune);
    }
    // this is just used for testing to instantiate runes to screen
    public void AddFourRunes(){
        ownedRunes.Add(new Rune(RuneTypeList.RuneTypes[0], RarityTypesList.Rarities[0], 24));
        ownedRunes.Add(new Rune(RuneTypeList.RuneTypes[1], RarityTypesList.Rarities[2],5));
        ownedRunes.Add(new Rune(RuneTypeList.RuneTypes[2], RarityTypesList.Rarities[4],70));
    }
}