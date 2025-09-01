using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardUI : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private TextMeshProUGUI _nameText;

    public void SetImage(Sprite sprite)
    {
        if (sprite == null || sprite == _image.sprite) return;

        _image.sprite = sprite;
    }

    public void SetNameText(string name)
    {
        if (name == _nameText.text) return;

        _nameText.text = name;
    }
}