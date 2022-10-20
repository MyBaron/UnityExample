using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example4
{
    public abstract class PlayerController :MonoBehaviour
{
    protected bool IsSit = false;
    protected int currentJumpCount = 0; 
    [Header("是否在地面")]
    public bool isGrounded = false;
    
    protected bool OnceJumpRayCheck = false;

    protected bool Is_DownJump_GroundCheck = false; 
    protected float m_MoveX;
    protected Rigidbody2D m_rigidbody;
    protected CapsuleCollider2D m_CapsulleCollider;
    protected Animator m_Anim;

    [Header("[Setting]")]
    protected float MoveSpeed = 6;
    protected int JumpCount = 2;
    protected float jumpForce = 15f;

    
    
    protected void AnimUpdate()
    {


        if (!m_Anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {


                m_Anim.Play("Attack");
            }
            else
            {

                if (m_MoveX == 0)
                {
                    if (!OnceJumpRayCheck)
                        m_Anim.Play("Idle");

                }
                else
                {

                    m_Anim.Play("Run");
                }

            }

        }
    }




    protected void Filp(bool bLeft)
    {


        transform.localScale = new Vector3(bLeft ? 1 : -1, 1, 1);

    }


    protected void prefromJump()
    {
        m_Anim.Play("Jump");

        m_rigidbody.velocity = new Vector2(0, 0);

        m_rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        OnceJumpRayCheck = true;
        isGrounded = false;


        currentJumpCount++;

    }

    protected void DownJump()
    {
        if (!isGrounded)
            return;


        if (!Is_DownJump_GroundCheck)
        {
            m_Anim.Play("Jump");

            m_rigidbody.AddForce(-Vector2.up * 10);
            isGrounded = false;

            m_CapsulleCollider.enabled = false;

            StartCoroutine(GroundCapsulleColliderTimmerFuc());

        }


    }

    IEnumerator GroundCapsulleColliderTimmerFuc()
    {
        yield return new WaitForSeconds(0.3f);
        m_CapsulleCollider.enabled = true;
    }


    Vector2 RayDir = Vector2.down;


    float PretmpY;
    float GroundCheckUpdateTic = 0;
    float GroundCheckUpdateTime = 0.01f;
    protected void GroundCheckUpdate()
    {
        if (!OnceJumpRayCheck)
            return;

        GroundCheckUpdateTic += Time.deltaTime;



        if (GroundCheckUpdateTic > GroundCheckUpdateTime)
        {
            GroundCheckUpdateTic = 0;



            if (PretmpY == 0)
            {
                PretmpY = transform.position.y;
                return;
            }



            float reY = transform.position.y - PretmpY;  //    -1  - 0 = -1 ,  -2 -   -1 = -3

            if (reY <= 0)
            {

                if (isGrounded)
                {

                    LandingEvent();
                    OnceJumpRayCheck = false;

                }
            }
            PretmpY = transform.position.y;
        }

    }

    protected abstract void LandingEvent();

}

}
