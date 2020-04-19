﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPlayer : MonoBehaviour
{
    private Animator _anim;

    [SerializeField]
    private FloatVariable _happiness;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        _happiness.Value = 0;
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            _anim.SetTrigger("Jump");
        }
    }
}
