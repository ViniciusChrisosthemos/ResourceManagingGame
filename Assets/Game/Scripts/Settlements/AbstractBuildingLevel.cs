using UnityEngine;

public abstract class AbstractBuildingLevel : ScriptableObject
{
    [SerializeField] private string _description;

    public abstract void ApplyLevel(AbstractBuilding building);
}
