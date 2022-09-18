using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_AddForce_Update : MonoBehaviour
{
    // 赋予2的力
    public float force = 2;
    private Rigidbody2D _rigidbody2D;
    // 移动方向
    private Vector3 dir = Vector3.right;
    private HeroPlayAnim _anim;
    
    void Start()
    {
        _anim = GetComponent<HeroPlayAnim>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        _anim.PlayWalkAnim(dir);
    }

    private void FixedUpdate()
    {
        _rigidbody2D.AddForce(Vector2.right * force);
    }
}
