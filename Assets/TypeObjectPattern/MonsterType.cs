using UnityEngine;

[CreateAssetMenu]
public class MonsterType : ScriptableObject
{
    public int StartingHealth;
    public int BaseSpeed;
    public MonsterType[] Weaknesses;
}
