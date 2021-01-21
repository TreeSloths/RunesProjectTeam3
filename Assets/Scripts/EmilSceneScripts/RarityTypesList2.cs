using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class RarityTypesList2 : MonoBehaviour{
    public List<Rarity2> Rarities;
    private void Awake(){
        Rarities.Add(new Rarity2("Common"));
        Rarities.Add(new Rarity2("Uncommon"));
        Rarities.Add(new Rarity2("Rare"));
        Rarities.Add(new Rarity2("Epic"));
        Rarities.Add(new Rarity2("Legendary"));
    }
    public Rarity2 RandomRarity(){
        var random = new Random();
        Rarity2 selected = Rarities[random.Next(0, Rarities.Count - 1)];
        return selected;
    }
}