using System.Collections;
using UnityEngine;

public class GenerateButton : InteractableButton
{
    [SerializeField] private DeckUIHandler _deckUIHandler;
    [SerializeField] private LinkButton _linkButton;
    [SerializeField] private CardsDatabase _cardsDatabase;

    private DeckGenerator _deckGenerator;

    #region Unity Lifecycle

    protected override void Awake()
    {
        base.Awake();
        _deckGenerator = new DeckGenerator(_cardsDatabase);
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        _linkButton.OnButtonClick += EnableButton;
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        _linkButton.OnButtonClick -= EnableButton;
    }

    #endregion

    protected override void OnClick()
    {
        base.OnClick();

        Deck deck = _deckGenerator.GetRandomDeck();

        _deckUIHandler.SetDeck(deck);
        _linkButton.SetLinkOnDeck(_deckGenerator.GenerateDeckLink(deck));

        _button.interactable = false;
    }

    private void EnableButton()
    {
        _button.interactable = true;
    }
}