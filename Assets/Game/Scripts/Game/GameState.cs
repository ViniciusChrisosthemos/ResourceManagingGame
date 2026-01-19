using System.Resources;
using UnityEngine;

public class GameState
{
    private int _currentTurn;
    private ResourceController _resourceController;

    public GameState(GameStateSO gameStateSO)
    {
        _currentTurn = gameStateSO.InitialTurn;
        _resourceController = new ResourceController(gameStateSO.InitialResources);
    }
}
