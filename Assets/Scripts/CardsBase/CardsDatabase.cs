using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Cards Database", menuName = "Cards/Database")]
public class CardsDatabase : ScriptableObject
{
    [SerializeField] private List<CardModel> _cards = new();

    public IReadOnlyList<CardModel> Cards => _cards;
}