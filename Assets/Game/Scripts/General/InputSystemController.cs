using UnityEngine;
using UnityEngine.InputSystem;

public class InputSystemController : Singleton<InputSystemController>
{
    [SerializeField] private PlayerInput _playerAction;

    private void Awake()
    {

    }
}
