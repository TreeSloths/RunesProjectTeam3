using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class RarityTypesList : MonoBehaviour{
    public List<Rarity> Rarities;
    private void Awake(){
        Rarities.Add(new Rarity("Common"));
        Rarities.Add(new Rarity("Uncommon"));
        Rarities.Add(new Rarity("Rare"));
        Rarities.Add(new Rarity("Epic"));
        Rarities.Add(new Rarity("Legendary"));
    }
    public Rarity RandomRarity(){
        var random = new Random();
        Rarity selected = Rarities[random.Next(0, Rarities.Count - 1)];
        return selected;
    }
}