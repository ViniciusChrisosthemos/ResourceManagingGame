using System;
using UnityEngine;

[Serializable]
public class ResourceHolder
{
    [SerializeField] private ResourceSO _resource;
    [SerializeField] private int _currentAmount;
    [SerializeField] private int _maxAmount;

    public ResourceSO Resource => _resource;
    public int CurrentAmount => _currentAmount;
    public int MaxAmount => _maxAmount;
}
