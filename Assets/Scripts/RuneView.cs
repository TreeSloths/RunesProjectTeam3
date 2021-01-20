using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneView : MonoBehaviour
{
    
    private RuneStack target;
    public void SetUp(RuneStack runeStack){ // needs to be implemented.
        //runeStack.OnCountChanged += UpdateCountLabel;
        this.target = runeStack;
    }
    void OnBeginDrag(){ // needs to be implemented.
        //var instance = InstantiatePrefab();
        //instance.SetUp(this.target.RuneType);
        //this.runeStack.RemoveOneRune();
    }
    public void SetUp(Rune rune){ // needs to be implemented.
        throw new System.NotImplementedException();
    }
}
