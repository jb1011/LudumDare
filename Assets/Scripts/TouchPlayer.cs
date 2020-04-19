using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject _touchParticleSystem;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Instantiate(_touchParticleSystem, gameObject.transform);
        }
    }
}
