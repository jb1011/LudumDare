using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    [SerializeField]
    private FloatVariable _happiness;

    [SerializeField]
    private Camera _camera;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Item"))
                    gameObject.SetActive(false);
                _happiness.Value += 10f;
            }
        } 
    }
}
