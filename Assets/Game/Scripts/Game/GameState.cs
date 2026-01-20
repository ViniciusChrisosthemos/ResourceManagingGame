using System;
using System.Collections.Generic;

public class GameState
{
    private int _currentTurn;
    private ResourceController _resourceController;

    public GameState(GameStateSO gameStateSO)
    {
        _currentTurn = gameStateSO.InitialTurn;
        _resourceController = new ResourceController(gameStateSO.InitialResources);
    }

    public int CurrentTurn => _currentTurn;
    public List<ResourceHolder> GetResources() => _resourceController.GetAllResources();

    public void NextTurn()
    {
        _currentTurn++;
    }
}
