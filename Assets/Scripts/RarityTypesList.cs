using System.Collections.Generic;
using Random = System.Random;

public static class RarityTypesList{
    public static List<Rarity> Rarities = new List<Rarity>{new Rarity("Common"),new Rarity("UnCommon"),new Rarity("Rare"),new Rarity("Epic"),new Rarity("Legendary")};
    public static Rarity RandomRarity(){
        var random = new Random();
        Rarity selected = Rarities[random.Next(0, Rarities.Count - 1)];
        return selected;
    }
}