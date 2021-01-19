using UnityEngine;

public class RuneInventoryView : MonoBehaviour {
    public RuneInventory runeInventory;
    void Awake(){
        runeInventory.RuneAdded += CreateRuneView;
    }
    void CreateRuneView(Rune rune){
        //need to be implemented.
        //var view = CreateView(); 
        //view.SetUp(rune);
    }
}