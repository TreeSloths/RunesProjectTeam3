using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;


public class RuneTypeList2 : MonoBehaviour{
    public List<string> RuneTypes;

    private void Awake(){
        RuneTypes.Add("Strength");
        RuneTypes.Add("Intelligence");
        RuneTypes.Add("Agility");
    }
    public string RandomRuneType(){
        var random = new Random();
        string selected = RuneTypes[random.Next(0, RuneTypes.Count - 1)];
        return selected;
    }
}