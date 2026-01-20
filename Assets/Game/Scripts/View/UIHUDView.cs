using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIHUDView : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameController _gameController;

    [Header("UI References")]
    [SerializeField] private UIListDisplay _resourcesListDisplay;
    [SerializeField] private TextMeshProUGUI _txtTurn;

    public void UpdateView(GameState gameState)
    {
        var resources = gameState.GetResources();

        _resourcesListDisplay.SetItems(resources, null);

        _txtTurn.text = $"Turn: {gameState.CurrentTurn}";
    }
}
