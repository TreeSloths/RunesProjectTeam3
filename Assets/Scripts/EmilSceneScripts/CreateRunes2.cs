using UnityEngine;


public class CreateRunes2 : MonoBehaviour{
    public RuneTypeList2 RuneTypeList;
    //public RarityTypesList rarityTypesList;
    
    public int amountOfRunes = 4;

    private GameObject Model;
    

    

    void Awake()
    {
        RuneTypeList = GetComponent<RuneTypeList2>();
        Model = GameObject.Find("Model");
    }

    public void CreateNewRune(){
        //for (int i = 0; i < amountOfRunes; i++){
            Model.GetComponent<RuneInventory2>().AddRune(new Rune2(RuneTypeList.RandomRuneType(), "Common"));
        //}
    }
    // Merging runes needs to be same color/type
    // Needs to take the list of added runes in the merge slots.
    // Need a ref to merge slots?
    // dropped rune in one slot adds to list
    // if rune is picked up from slot then remove rune from list
    public void MergeRunes(Rune[] runes, int amount){
        
        if (amount == 2){
            // 20 % chance for upgraded rarity
        }
        if (amount == 3){
            // 55 % chance for upgraded rarity
        }
        if (amount == 4){
            // 95 % chance for upgraded rarity
        }
    }
}