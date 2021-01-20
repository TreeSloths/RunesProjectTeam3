using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public static class RuneTypeList{
    public static List<RuneType> RuneTypes = new List<RuneType>{new RuneType("Strength", Color.red),new RuneType("Intelligence", Color.blue),new RuneType("Agility", Color.green)};
    public static RuneType RandomRuneType(){
        var random = new Random();
        RuneType selected = RuneTypes[random.Next(0, RuneTypes.Count - 1)];
        return selected;
    }
}