using UnityEngine;

public abstract class AbstractBuilding: ScriptableObject
{
    [SerializeField] private string _buildingName;
    [SerializeField] private Sprite _icon;
    [SerializeField] private int _turnsToBuild;

    public abstract void ApplyTurn(GameState gameState);
}
