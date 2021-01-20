using UnityEngine;
[CreateAssetMenu(fileName = "New Rune", menuName = "Rune")]
public class RuneData : ScriptableObject
{
    public RuneType runeType;
    public Rarity rarity;
}
