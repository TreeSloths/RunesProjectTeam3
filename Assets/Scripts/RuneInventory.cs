using System.Collections.Generic;

public class RuneInventory{
    public event System.Action<Rune> RuneAdded;
    List<Rune> ownedRunes;
    public void AddRune(Rune rune){
        this.ownedRunes.Add(rune);
        this.RuneAdded?.Invoke(rune);
    }
}