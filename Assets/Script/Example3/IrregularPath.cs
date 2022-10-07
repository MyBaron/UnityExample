using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrregularPath : MonoBehaviour
{
    [SerializeField]
    private List<Vector2> _positions;
    // 开始位置
    public Vector3 startPosition;
    // 持续时间
    public float lerpDuration = 0.5F;
    // 记录运行时间
    private float _timeElapsed = 0;

    private void Start()
    {
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        while (true)
        {
            foreach (var position in _positions)
            {
                var complete = false;
                startPosition = transform.position;
                _timeElapsed = 0;
                while (!complete)
                {
                    // 记录下一个位置
                    Vector3 valueToLerp;
                    _timeElapsed += Time.deltaTime;
                    if (_timeElapsed < lerpDuration)
                    {
                        valueToLerp  = Vector3.Lerp(startPosition, position, _timeElapsed / lerpDuration);
                    }
                    else
                    {
                        valueToLerp = position;
                        complete = true;
                    }
                    transform.position = valueToLerp;
                    yield return null;
                }
            }
        }
    }
}
