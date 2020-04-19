using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DragAndDrop : MonoBehaviour
{
    float _ZPosition;
    Vector3 _Offset;

    [SerializeField]
    Camera _camera;

    bool _dragging;

    [SerializeField]
    public UnityEvent OnBeginDrag;

    [SerializeField]
    public UnityEvent OnEndDrag;
    private void Start()
    {
        _ZPosition = _camera.WorldToScreenPoint(transform.position).z;
    }

    private void Update()
    {
        if (_dragging)
        {
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _ZPosition);
            transform.position = _camera.ScreenToWorldPoint(position + new Vector3(_Offset.x, _Offset.y));
        }
    }

    private void OnMouseDown()
    {
        if (!_dragging)
        {
            BeginDrag();
        }
    }

    private void OnMouseUp()
    {
        EndDrag();
    }

    public void BeginDrag()
    {
        _dragging = true;
        _Offset = _camera.WorldToScreenPoint(transform.position) - Input.mousePosition;
    }

    public void EndDrag()
    {
        _dragging = false;
    }
}
