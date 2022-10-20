using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example4
{
    public class GroundSensor : MonoBehaviour
    {

        public bool isGrounded;

        private void OnTriggerStay2D(Collider2D other)
        {
            if (other.CompareTag("Ground"))
            {
                isGrounded = true;
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Ground"))
            {
                isGrounded = false;
            }
        }
    }
 
}
