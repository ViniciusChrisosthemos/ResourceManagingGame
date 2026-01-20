using UnityEngine;
using UnityEngine.Events;

public class GameController : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private GameStateSO _gameStateSettingsSO;

    [Header("UI References")]
    [SerializeField] private UIHUDView _hudViews;

    private GameState _currentGameState;

    private void Awake()
    {
        _currentGameState = new GameState(_gameStateSettingsSO);
    }

    private void Start()
    {
        _hudViews.UpdateView(_currentGameState);
    }

    public void PassTurn()
    {
        _currentGameState.NextTurn();

        _hudViews.UpdateView(_currentGameState);
    }
}
