using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGravity : MonoBehaviour
{

    private Rigidbody2D _rigidbody2D;
    [Header("εδΈηε")]
    [SerializeField]
    private float _force;
    
    void Start()
    {
        _rigidbody2D = transform.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody2D.AddForce(new Vector3(0, _force, 0));
    }
}
