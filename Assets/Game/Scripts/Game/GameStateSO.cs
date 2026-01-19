using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameStateSO", menuName = "ScriptableObjects/Game/Game State")]
public class GameStateSO : ScriptableObject
{
    [SerializeField] private int _initialTurn = 1;
    [SerializeField] private List<ResourceHolder> _initialResources;

    public int InitialTurn => _initialTurn;
    public List<ResourceHolder> InitialResources => _initialResources;
}
