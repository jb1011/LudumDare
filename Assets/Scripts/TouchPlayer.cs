using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPlayer : MonoBehaviour
{
    [SerializeField]
    private Animator _anim;

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            _anim.SetTrigger("Jump");
        }
    }
}
