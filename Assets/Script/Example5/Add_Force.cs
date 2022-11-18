using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_Force : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    [SerializeField]
    private float _force;
    
    void Start()
    {
        _rigidbody2D = transform.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody2D.AddForce(Vector2.right * _force);
    }
}
