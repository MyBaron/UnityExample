using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp_Error1 : MonoBehaviour
{
    // 终点
    public Vector3 targetPosition;
    // 开始位置
    public Vector3 startPosition;
    
    private void Start()
    {
        transform.position = startPosition;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
    }
}
