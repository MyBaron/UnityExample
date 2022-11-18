using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    [Header("力")]
    [SerializeField]
    private float _force;
    
    void Start()
    {
        _rigidbody2D = transform.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody2D.AddForce(Vector2.right * _force);
        Debug.Log("addForce");
    }
}
