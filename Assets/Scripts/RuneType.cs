using System;
using UnityEngine;
[Serializable]
public class RuneType{
    public string runeType;
    public Color typeColor;
    public RuneType(string runeType, Color typeColor){
        this.runeType = runeType;
        this.typeColor = typeColor;
    }
}