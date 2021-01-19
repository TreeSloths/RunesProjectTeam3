using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class RuneTypeList{
    public List<RuneType> RuneTypes = new List<RuneType>();
    private void Awake(){
        RuneTypes.Add(new RuneType("Strength"));
        RuneTypes.Add(new RuneType("Intelligence"));
        RuneTypes.Add(new RuneType("Agility"));
    }
    public RuneType RandomRuneType(){
        var random = new Random();
        RuneType selected = RuneTypes[random.Next(0, RuneTypes.Count - 1)];
        return selected;
    }
}