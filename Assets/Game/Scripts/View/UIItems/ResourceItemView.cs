using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResourceItemView : UIItemController
{
    [SerializeField] private Image _imgIcon;
    [SerializeField] private TextMeshProUGUI _txtResourceValue;

    private ResourceHolder _resourceHolder;

    protected override void HandleInit(object obj)
    {
        _resourceHolder = obj as ResourceHolder;

        _imgIcon.sprite = _resourceHolder.Resource.Icon;
        _txtResourceValue.text = $"{_resourceHolder.CurrentAmount}";
    }
}
