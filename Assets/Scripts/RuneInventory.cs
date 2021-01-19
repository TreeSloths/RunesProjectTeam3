using System.Collections.Generic;
using UnityEngine;

public class RuneInventory : MonoBehaviour{
    public event System.Action<Rune> RuneAdded;
    public List<Rune> ownedRunes = new List<Rune>();
    public void AddRune(Rune rune){
        this.ownedRunes.Add(rune);
        this.RuneAdded?.Invoke(rune);
    }

    public void AddFourRunes(){
        if (ownedRunes == null){
            ownedRunes.Add(new Rune(new RuneType("Str"), new Rarity("Sweet")));
            ownedRunes.Add(new Rune(new RuneType("Int"), new Rarity("Sour")));
            ownedRunes.Add(new Rune(new RuneType("Dex"), new Rarity("Poppy")));
            ownedRunes.Add(new Rune(new RuneType("Agi"), new Rarity("Bland")));
        }
    }
}