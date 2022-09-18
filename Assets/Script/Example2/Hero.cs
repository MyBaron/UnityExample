using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    private const float _speed = 10f;

    private HeroPlayAnim _anim;

    // 上一个移动方向
    private Vector3 _lastMoveDir;
    
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<HeroPlayAnim>();
        _lastMoveDir = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }
    
    private void HandleMovement() {
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W)) {
            moveY = +1f;
        }
        if (Input.GetKey(KeyCode.S)) {
            moveY = -1f;
        }
        if (Input.GetKey(KeyCode.A)) {
            moveX = -1f;
        }
        if (Input.GetKey(KeyCode.D)) {
            moveX = +1f;
        }

        Vector3 moveDir = new Vector3(moveX, moveY).normalized;
        bool isIdle = moveX == 0 && moveY == 0;
        if (isIdle) {
            // 播放动画
           _anim.PlayIdleAnim(_lastMoveDir);
        } else {
            // 播放动画
            transform.position += moveDir * (_speed * Time.deltaTime);
            _anim.PlayWalkAnim(moveDir);
        }

        if (!isIdle)
        {
            _lastMoveDir = moveDir;
        }
    }
}
