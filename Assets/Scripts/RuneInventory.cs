using System.Collections.Generic;

public class RuneInventory{
    public event System.Action<Rune> RuneAdded;
    List<Rune> runes;
    public void AddRune(Rune rune){
        this.runes.Add(rune);
        this.RuneAdded?.Invoke(rune);
    }
}