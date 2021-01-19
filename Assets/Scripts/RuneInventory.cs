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
        ownedRunes.Add(new Rune(new RuneType("Strength", Color.red), new Rarity("Rare"), 24));
        ownedRunes.Add(new Rune(new RuneType("Intelligence", Color.blue), new Rarity("Epic"),5));
        ownedRunes.Add(new Rune(new RuneType("Agility",Color.green), new Rarity("Legendary"),70));
    }
}