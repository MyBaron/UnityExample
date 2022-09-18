using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_Position : MonoBehaviour
{
    private HeroPlayAnim _anim;
    
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<HeroPlayAnim>();
        //Application.targetFrameRate = 10;
    }
    void Update()
    {
        var dir = new Vector3(0.01f, 0, 0);
        transform.position += dir;
        _anim.PlayWalkAnim(dir);
    }
}
