using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example5
{
    public class Player_1 : Example5.PlayerController_1
    {

        public bool isMove = false;
    
    
        private void Start()
        {

            m_CapsulleCollider  = this.transform.GetComponent<CapsuleCollider2D>();
            m_Anim = this.transform.Find("Script").GetComponent<Animator>();
            m_rigidbody = this.transform.GetComponent<Rigidbody2D>();
        }



        private void Update()
        {
            // 输入
            checkInput();
        }

        public void checkInput()
        {
            isMove = false;

            if (Input.GetKeyUp(KeyCode.S))
            {
                m_Anim.SetTrigger("Idle");
                m_Anim.Play("Idle");
                IsSit = false;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (currentJumpCount < JumpCount)  // 0 , 1
                {
                    DownJump();
                }
            }


            m_MoveX = Input.GetAxis("Horizontal");
   
            GroundCheckUpdate();


            if (m_MoveX == 0)
            {
                //if (!OnceJumpRayCheck)
                    m_Anim.SetTrigger("Idle");
                    m_Anim.Play("Idle");
            }
            else
            {

                m_Anim.Play("Walk");
            }

            // 右
            if (Input.GetKey(KeyCode.D))
            {
                isMove = true;

                if (isGrounded) 
                {

                    transform.transform.Translate(Vector2.right* m_MoveX * MoveSpeed * Time.deltaTime);
                }
                else
                {

                    transform.transform.Translate(new Vector3(m_MoveX * MoveSpeed * Time.deltaTime, 0, 0));

                }


                if (!Input.GetKey(KeyCode.A))
                    Filp(true);


            }
            // 左
            else if (Input.GetKey(KeyCode.A))
            {

                isMove = true;

                if (isGrounded)  
                {


                    transform.transform.Translate(Vector2.right * m_MoveX * MoveSpeed * Time.deltaTime);

                }
                else
                {

                    transform.transform.Translate(new Vector3(m_MoveX * MoveSpeed * Time.deltaTime, 0, 0));

                }


                if (!Input.GetKey(KeyCode.D))
                    Filp(false);


            }


            // 空格
            if (Input.GetKeyDown(KeyCode.Space))
            {

                prefromJump();
               // DownJump();
                isMove = true;
            }

        }
    

        protected override void LandingEvent()
        {

            if (!m_Anim.GetCurrentAnimatorStateInfo(0).IsName("Run") && !m_Anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
                m_Anim.Play("Idle");
        }

    }

}