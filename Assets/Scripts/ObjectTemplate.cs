using UnityEngine;
[CreateAssetMenu(fileName = "New Rune", menuName = "Rune")]
public class ObjectTemplate : ScriptableObject
{
    public new string name;
    public string rarity;
    public Color typeColor;
    public int amount;
}
