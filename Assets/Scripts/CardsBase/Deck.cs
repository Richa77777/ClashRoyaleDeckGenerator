using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

public class Deck
{
    private readonly ReadOnlyCollection<CardModel> _cards;
    private readonly CardModel _towerCard;

    public IReadOnlyList<CardModel> Cards => _cards;
    public CardModel TowerCard => _towerCard;

    public Deck(List<CardModel> cards, CardModel towerCard)
    {
        _cards = new ReadOnlyCollection<CardModel>(cards?.ToList() ?? new List<CardModel>());
        _towerCard = towerCard ?? throw new System.ArgumentNullException(nameof(towerCard));
    }
}
