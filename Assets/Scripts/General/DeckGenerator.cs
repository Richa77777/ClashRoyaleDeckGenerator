using System.Collections.Generic;
using System.Linq;

public class DeckGenerator
{
    public const int DECK_SIZE = 8;

    private readonly CardsDatabase _cardsDatabase;

    public DeckGenerator(CardsDatabase cardsDatabase)
    {
        _cardsDatabase = cardsDatabase;
    }

    public Deck GetRandomDeck()
    {
        List<CardModel> cardsPool = new List<CardModel>(_cardsDatabase.Cards);
        List<CardModel> deck = new();
        bool hasChampion = false;

        cardsPool.Shuffle();

        foreach (var card in cardsPool)
        {
            if (deck.Count >= DECK_SIZE)
                break;

            if (card.Rarity == Rarity.Champion && hasChampion)
                continue;

            if (deck.Contains(card))
                continue;

            deck.Add(card);

            if (card.Rarity == Rarity.Champion)
                hasChampion = true;
        }

        return new Deck(deck, GetRandomTowerCard());
    }

    public string GenerateDeckLink(Deck deck)
    {
        string deckIdsString = string.Join(";", deck.Cards
            .Select(c => c.Id.Trim()));
        string towerId = deck.TowerCard.Id.Trim();

        return $"https://link.clashroyale.com/en?clashroyale://copyDeck?deck={deckIdsString}&slots=0;0;0;0;0;0;0;0&tt={towerId}&l=Royals";
    }


    private CardModel GetRandomTowerCard()
    {
        return _cardsDatabase.TowerCards[UnityEngine.Random.Range(0, _cardsDatabase.TowerCards.Count)];
    }
}