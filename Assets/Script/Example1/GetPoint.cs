using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPoint : MonoBehaviour
{
    // 坐标点A
    public Vector2 a;

    //  坐标点B
    public Vector2 b;

    // 比值
    public float ratio;

    private void Update()
    {
        var position = Vector3.Lerp(a, b, ratio);
        transform.position = position;
    }
}
