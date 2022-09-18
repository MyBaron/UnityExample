using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_SmoothDamp : MonoBehaviour
{
    public Vector3 targetPosition;
    public float speed = 3;
    public float smoothTime = 0.5f; 
    Vector3 velocity = Vector3.zero;
    
    private HeroPlayAnim _anim;
    
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<HeroPlayAnim>();
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime, speed);
        var dir = targetPosition - targetPosition;
        _anim.PlayWalkAnim(dir);
    }
}
