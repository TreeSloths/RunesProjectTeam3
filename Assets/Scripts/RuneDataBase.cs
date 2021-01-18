using System.Collections.Generic;
using UnityEngine;

public class RuneDataBase : MonoBehaviour
{
    public static List<RuneData> RuneList = new List<RuneData>();
    private const string strength = "Strength";
    private const string intelligence = "intelligence";
    private const string agillity = "agillity";
    private const string common = "Common";
    private const string uncommon = "Uncommon";
    private const string rare = "Rare";
    private const string epic = "Epic";
    private const string legendary = "Legendary";
    private void Awake(){
        RuneList.Add(new RuneData(strength+common, common, Color.red, 0,0));
        RuneList.Add(new RuneData(strength+uncommon, uncommon, Color.red, 0,1));
        RuneList.Add(new RuneData(strength+rare, rare, Color.red, 0,2));
        RuneList.Add(new RuneData(strength+epic, epic, Color.red, 0,3));
        RuneList.Add(new RuneData(strength+legendary, legendary, Color.red, 0,4));

        RuneList.Add(new RuneData(intelligence+common, common, Color.blue, 0,5));
        RuneList.Add(new RuneData(intelligence+uncommon, uncommon, Color.blue, 0,6));
        RuneList.Add(new RuneData(intelligence+rare, rare, Color.blue, 0,7));
        RuneList.Add(new RuneData(intelligence+epic, epic, Color.blue, 0,8));
        RuneList.Add(new RuneData(intelligence+legendary, legendary, Color.blue, 0,9));

        RuneList.Add(new RuneData(agillity+common, common, Color.green, 0,10));
        RuneList.Add(new RuneData(agillity+uncommon, uncommon, Color.green, 0,11));
        RuneList.Add(new RuneData(agillity+rare, rare, Color.green, 0,12));
        RuneList.Add(new RuneData(agillity+epic, epic, Color.green, 0,13));
        RuneList.Add(new RuneData(agillity+legendary, legendary, Color.green, 0,14));
    }
}
