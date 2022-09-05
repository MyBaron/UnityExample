using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/*
 * 依靠碰撞器检测目标
 */
public class DetectTargetByCollider : MonoBehaviour
{

    private List<GameObject> detects = new List<GameObject>();

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Monster"))
        {
            detects.Add(col.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Monster"))
        {
            detects.Remove(other.gameObject);
            
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (detects == null)
        {
            return;
        }
        Gizmos.color = Color.blue;
        foreach (var detect in detects)
        {
            Gizmos.DrawSphere(detect.transform.position,0.3f);
        }
    }
}
