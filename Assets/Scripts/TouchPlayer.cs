using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPlayer : MonoBehaviour
{
    private Animator _anim;

    [SerializeField]
    private FloatVariable _happiness;

    [SerializeField]
    private Camera _camera;
    private void Start()
    {
        _anim = GetComponent<Animator>();
        _happiness.Value = 0;
    }

    void Update()
    {
        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        //{
        //    _anim.SetTrigger("Jump");
        //}
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Player"))
                {
                    _anim.SetTrigger("Jump");
                }
            }
        }
        
    }
}
