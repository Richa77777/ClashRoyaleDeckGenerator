using System;
using UnityEngine;
using UnityEngine.UI;

public class InteractableButton : MonoBehaviour
{
    [SerializeField] protected Button _button;
    public event Action OnButtonClick;

    #region Unity Lifecycle

    protected virtual void Awake()
    {
        if (_button == null)
            _button = GetComponent<Button>();
    }

    protected virtual void OnEnable()
    {
        _button.onClick.AddListener(OnClick);
    }

    protected virtual void OnDisable()
    {
        _button.onClick.RemoveListener(OnClick);
    }

    #endregion

    protected virtual void OnClick()
    {
        Debug.Log($"Button \"{gameObject.name}\" Clicked");
        OnButtonClick?.Invoke();
    }
}
