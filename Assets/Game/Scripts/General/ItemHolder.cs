using System;
using UnityEngine;

[Serializable]
public class ItemHolder<T>
{
    [SerializeField] private T _item;
    [SerializeField] private int _amount;

    public void SetAmount(int amount)
    {
        _amount = amount;
    }

    public T Item => _item;
    public int Amount => _amount;
}
