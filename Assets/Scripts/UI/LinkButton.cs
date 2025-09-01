using UnityEngine;

public class LinkButton : InteractableButton
{
    private string _linkOnDeck;

    protected override void OnClick()
    {
        base.OnClick();

        Application.OpenURL(_linkOnDeck);
    }

    public void SetLinkOnDeck(string linkOnDeck)
    {
        _linkOnDeck = linkOnDeck;
    }
}
