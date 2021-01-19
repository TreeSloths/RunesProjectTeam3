using UnityEngine;

public class RuneInventoryView : MonoBehaviour {
    public RuneInventory runeInventory;
    public Rune rune;
    void Awake(){
        runeInventory.RuneAdded += CreateRuneView;
        rune.AmountAdded += AmountChanged;
    }
    void CreateRuneView(Rune rune){
        //need to be implemented.
        //var view = CreateView(); 
        //view.SetUp(rune);
    }

    void AmountChanged(int amountChanged){
        
    }
}