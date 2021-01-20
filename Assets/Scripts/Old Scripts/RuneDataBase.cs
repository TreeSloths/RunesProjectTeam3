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

    }
}
