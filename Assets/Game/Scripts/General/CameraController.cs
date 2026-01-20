using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _target;
    [SerializeField] private float _moveSpeed = 0.2f;

    [Header("Zoom")]
    [SerializeField, Min(0)] private float _minZoom;
    [SerializeField] private float _maxZoom;
    [SerializeField] private float _zoomStep = 0.1f;

    private bool _isMovingCamera = false;
    private Vector3 _cameraPositionPivot;
    private Vector2 _mousePositionPivot;

    private float _currentZoom;
    private float _defaultFOV;

    private void Awake()
    {
        _currentZoom = 0;
        _defaultFOV = _camera.fieldOfView;
    }

    private void Update()
    {
        if (_isMovingCamera)
        {
            MoveCamera();
        }
    }

    private void MoveCamera()
    {
        var cameraPosition2d = Mouse.current.position;

        var posDiff = _mousePositionPivot;

        posDiff.x -= cameraPosition2d.x.value;
        posDiff.y -= cameraPosition2d.y.value;

        posDiff *= _moveSpeed;

        _target.position = new Vector3(_cameraPositionPivot.x + posDiff.x, _target.position.y, _cameraPositionPivot.z + posDiff.y);
    }

    private void Zoom(float value)
    {
        var step = _zoomStep * value * -1;
        _currentZoom = Mathf.Clamp(_currentZoom + step, _minZoom, _maxZoom);

        _camera.fieldOfView = _defaultFOV + _currentZoom;
    }

    private void OnMouseScroll(InputValue inputValue)
    {
        var scrollValue = inputValue.Get<Vector2>();

        if (scrollValue.y != 0)
        {
            Zoom(scrollValue.y);
        }
    }

    private void OnMouseLeftClick(InputValue inputValue)
    {
        _isMovingCamera = inputValue.isPressed;

        _cameraPositionPivot = _target.position;
        _mousePositionPivot = new Vector2(Mouse.current.position.x.value, Mouse.current.position.y.value);
    }

    private void OnMouseRightClick(InputValue inputValue)
    {

    }
}
