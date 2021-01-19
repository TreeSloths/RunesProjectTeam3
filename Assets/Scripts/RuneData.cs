using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneData : MonoBehaviour
{
    private string runeName;
    private string rarity;
    private Color typeColor;
    private int amount;
    //private int idNumber;
    private string id;

    public RuneData(string runeName, string rarity, Color color, int amount/*, int idNumber*/){
        this.runeName = runeName;
        this.rarity = rarity;
        this.typeColor = color;
        this.amount = amount;
        this.idNumber = idNumber;
        this.id = $"{runeName} {rarity} {color} {amount}";
    }
}
