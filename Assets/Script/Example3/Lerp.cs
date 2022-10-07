using System;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    // 终点
    public Vector3 b;
    // 开始位置
    public Vector3 a;
    // 持续时间
    public float duraction = 1f;
    // 记录运行时间
    private float _timeElapsed = 0;

    private void Start()
    {
        transform.position = a;
    }

    private void Update()
    {
        Vector3 valueToLerp;
        _timeElapsed += Time.deltaTime;
        if (_timeElapsed < duraction)
        {
            valueToLerp = Vector3.Lerp(a, b, _timeElapsed / duraction);
        }
        else
        {
            valueToLerp = b;
        }
        transform.position = valueToLerp;
    }
}
