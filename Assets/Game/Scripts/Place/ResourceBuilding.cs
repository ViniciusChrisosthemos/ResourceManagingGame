using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ResourceBuilding_", menuName = "ScriptableObjects/Game/Buildings/Farm")]
public class ResourceBuilding : AbstractBuilding
{
    [SerializeField] private int _amountToGain;
    [SerializeField] private List<ResourceSO> _resourcesToGain;

    public int AmountToGain => _amountToGain;

    public List<ResourceSO> ResourcesToGain => _resourcesToGain;

    public override void ApplyTurn(GameState gameState)
    {
        //TODO
    }
}
