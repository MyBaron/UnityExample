using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroPlayAnim : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    [SerializeField]
    private SpriteRenderer _spriteRenderer;

    // 站立动画
    public void PlayIdleAnim(Vector3 dir)
    {
        _animator.SetInteger("State",0);
        var direction = handleDir(dir);
        switch (direction)
        {
            case Dir.Down: _animator.SetInteger("Dir",0);
                break;
            case Dir.Left:  _spriteRenderer.flipX = false;
                _animator.SetInteger("Dir",1);
                break;
            case Dir.Right: _spriteRenderer.flipX = true;
                _animator.SetInteger("Dir",1);
                break;
            case Dir.Up: _animator.SetInteger("Dir",2);
                break;
        }
    }

    public void PlayWalkAnim(Vector3 dir)
    {
        _animator.SetInteger("State",1);
        var direction = handleDir(dir);
        switch (direction)
        {
            case Dir.Down: _animator.SetInteger("Dir",0);
                break;
            case Dir.Left:  _spriteRenderer.flipX = false;
                _animator.SetInteger("Dir",1);
                break;
            case Dir.Right: _spriteRenderer.flipX = true;
                _animator.SetInteger("Dir",1);
                break;
            case Dir.Up: _animator.SetInteger("Dir",2);
                break;
        }
    }

    private Dir handleDir(Vector3 dir)
    {

        if (dir.x < 0 && dir.y == 0)
        {
            // 向左
            return Dir.Left;
        }else if (dir.x >= 0 && dir.y == 0)
        {
            // 向右
            return Dir.Right;
        }else if (dir.x == 0 && dir.y > 0)
        {
            //  向上
            return Dir.Up;
        }else if (dir.x == 0 && dir.y < 0)
        {
            //向下
            return Dir.Down;
        }
        else
        {
            // 默认值
            return Dir.Down;
        }
       
    }
    
    private enum Dir
    {
        Up,
        Down,
        Left,
        Right
    }
}
