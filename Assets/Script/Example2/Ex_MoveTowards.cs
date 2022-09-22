using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_MoveTowards : MonoBehaviour
{
    public Vector3 targetPosition;
    public float speed = 3;
    
    private HeroPlayAnim _anim;
    
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<HeroPlayAnim>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        var dir = targetPosition - targetPosition;
        _anim.PlayWalkAnim(dir);
    }
}
