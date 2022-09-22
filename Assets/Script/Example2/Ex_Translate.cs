using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_Translate : MonoBehaviour
{
    private HeroPlayAnim _anim;
    public float speed = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<HeroPlayAnim>();
        Application.targetFrameRate = 100;
    }
    void Update()
    {
        var dir = Vector3.right * (speed * Time.deltaTime);
        transform.Translate(dir);
        _anim.PlayWalkAnim(dir);
    }
}
