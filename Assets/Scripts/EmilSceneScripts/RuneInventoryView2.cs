using UnityEngine;

public class RuneInventoryView2 : MonoBehaviour {
    public RuneInventory2 RuneInventory;
    void Awake(){
        RuneInventory = GetComponent<RuneInventory2>();
        RuneInventory.RuneAdded += CreateRuneView;
    }
    void CreateRuneView(Rune2 rune){
        Debug.Log(rune.rarity);
        GameObject.Find("TestText").GetComponent<UnityEngine.UI.Text>().text += $"{rune.runeType} {rune.rarity} ";
    }
}