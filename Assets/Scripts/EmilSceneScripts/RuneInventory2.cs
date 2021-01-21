using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RuneInventory2 : MonoBehaviour
{
    public event System.Action<Rune2> RuneAdded;
    [SerializeField] private List<Rune2> ownedRunes = new List<Rune2>();
    public void AddRune(Rune2 rune){
       // Debug.Log(rune.runeType);
        
        ownedRunes.Add(rune);
        RuneAdded?.Invoke(rune);
    }
}