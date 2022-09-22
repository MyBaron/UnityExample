using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Ex_MovePosition : MonoBehaviour
{
    // 速度
    public float speed = 10;
    private Rigidbody2D _rigidbody2D;
    // 移动方向
    private Vector3 dir = Vector3.right;
    private HeroPlayAnim _anim;
    
    // Start is called before the first frame update
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
        var positon = dir * (speed * Time.deltaTime);
        Debug.Log($"FixedUpdate{Time.deltaTime}");
        _rigidbody2D.MovePosition(transform.position + positon);
    }
}
