using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_Lerp : MonoBehaviour
{
    // 终点
    public Vector3 targetPosition;
    // 开始位置
    public Vector3 startPosition;
    // 持续时间
    public float lerpDuration = 4;
    // 记录运行时间
    private float _timeElapsed = 0;
    
    
    private HeroPlayAnim _anim;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<HeroPlayAnim>();
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // 记录下一个位置
        Vector3 valueToLerp;
        _timeElapsed += Time.deltaTime;
        if (_timeElapsed < lerpDuration)
        {
            valueToLerp  = Vector3.Lerp(startPosition, targetPosition, _timeElapsed / lerpDuration);
        }
        else
        {
            valueToLerp = targetPosition;
        }
        transform.position = valueToLerp;
        var dir = targetPosition - targetPosition;
        _anim.PlayWalkAnim(dir);
    }
}
