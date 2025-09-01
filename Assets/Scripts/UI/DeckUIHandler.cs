using System.Collections.Generic;
using UnityEngine;

public class DeckUIHandler : MonoBehaviour
{
    [SerializeField] private List<CardUI> _deckCards = new();
    [SerializeField] private CardUI _towerCard;

    public void SetDeck(Deck deck)
    {
        if (_deckCards.Count < deck.Cards.Count) { Debug.LogError("Не хватает UI слотов для всех карт!"); return; }

        for (int i = 0; i < deck.Cards.Count; i++)
        {
            _deckCards[i].SetNameText(deck.Cards[i].Name);
            _deckCards[i].SetImage(deck.Cards[i].Sprite);
        }

        _towerCard.SetNameText(deck.TowerCard.Name);
        _towerCard.SetImage(deck.TowerCard.Sprite);
    }
}
