using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example4
{
    public class GroupSensor_Ray : MonoBehaviour
    {
        public bool isGrounded;
        public LayerMask layerMask;

        private void Update()
        {
            var rayCastAll = Physics2D.RaycastAll(transform.position, Vector2.down, 0.1f, layerMask);
            if (rayCastAll.Length > 0)
            {
                isGrounded = true;
            }
            else
            {
                isGrounded = false;
            }
            
        }


        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawRay(transform.position,Vector3.down * 0.1f); 
        }
    }

}
