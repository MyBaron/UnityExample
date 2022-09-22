using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_Position : MonoBehaviour
{

    private HeroPlayAnim _anim;
    private float speed = 2;
    private Vector3 dir = Vector3.right;

    private void Start()
    {
        _anim = GetComponent<HeroPlayAnim>();
    }

    private void Update()
    {
        transform.Translate(dir * (speed * Time.deltaTime));
        _anim.PlayWalkAnim(dir);
    }
}
