using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Cards/Card")]
public class CardModel : ScriptableObject
{
    [field: SerializeField] public string Id { get; private set; } = "26000000";
    [field: SerializeField] public string Name { get; private set; } = "׀ûצאנü";
    [field: SerializeField] public int ElixirCost { get; private set; } = 3;
    [field: SerializeField] public Rarity Rarity { get; private set; } = Rarity.Common;
    [field: SerializeField] public Sprite Sprite { get; private set; }
}

public enum Rarity
{
    Common,
    Rare,
    Epic,
    Legendary,
    Champion
}