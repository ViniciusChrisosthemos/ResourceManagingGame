using UnityEngine;
using UnityEngine.EventSystems;

public class PlaceController : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log($"{name}");
    }
}
