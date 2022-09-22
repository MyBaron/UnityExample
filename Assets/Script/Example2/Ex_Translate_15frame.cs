using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_Translate_15frame : MonoBehaviour
{
    private HeroPlayAnim _anim;
    // 模拟掉帧
    private int frame = 0;
    private float time = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<HeroPlayAnim>();
        
    }
    void Update()
    {
        frame++;
        time += Time.deltaTime;
        if (frame % 5 != 0)
        {
            return;
        }
        var dir = new Vector3(1f, 0, 0)*time;
        transform.Translate(dir);
        _anim.PlayWalkAnim(dir);
        time = 0;
    }
}
