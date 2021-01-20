using UnityEngine;

public class RuneInventoryView : MonoBehaviour {
    public RuneInventory runeInventory;
    public RuneView runeViewPrefab;
    void Awake(){
        runeInventory.RuneAdded += CreateRuneView;
    }
    void CreateRuneView(Rune rune){
        //need to be implemented.
        var view = CreateView(); 
        view.SetUp(rune);
    }

    private RuneView CreateView(){
        return Instantiate(this.runeViewPrefab);
    }
}