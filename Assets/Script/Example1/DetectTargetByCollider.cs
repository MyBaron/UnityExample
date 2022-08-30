using System;
using System.Collections.Generic;
using UnityEngine;

/*
 * 依靠碰撞器检测目标
 */
public class DetectTargetByCollider : MonoBehaviour
{
    
    /*检测到的对象*/
    private List<GameObject> detect = new List<GameObject>();
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Monster"))
        {
            detect.Add(col.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Monster"))
        {
            detect.Remove(other.gameObject);
        }
    }
    
    private void OnDrawGizmosSelected()
    {
       // Gizmos.DrawWireSphere(transform.position, 2);

        if (detect == null)
            return;
        Gizmos.color = Color.magenta;
        foreach (var item in detect)
        {
            Gizmos.DrawSphere(item.transform.position, 0.3f);
        }
    }
}
