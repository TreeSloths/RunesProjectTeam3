using UnityEngine;
[CreateAssetMenu(fileName = "New Rune", menuName = "Rune")]
public class ObjectTemplate : ScriptableObject
{
    public string name;
    public string type;
    public Color typeColor;
    public int rarityLevel;
}
