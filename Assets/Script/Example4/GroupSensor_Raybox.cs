using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example4
{
    public class GroupSensor_Raybox : MonoBehaviour
    {
        public bool isGrounded;
        public LayerMask layerMask;
   
        void Update()
        {
            var raycastAll = Physics2D.OverlapBoxAll(transform.position, new Vector2(0.4f, 0.4f), 0, layerMask);
            if (raycastAll.Length > 0)
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
            Gizmos.DrawWireCube(transform.position,new Vector2(0.4f,0.4f));
          
        }
    }

}
