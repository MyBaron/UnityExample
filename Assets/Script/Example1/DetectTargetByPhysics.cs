
using System;
using System.Collections.Generic;
using UnityEngine;

/*
 * 依靠物理射线检测目标
 */
public class DetectTargetByPhysics : MonoBehaviour
{
    public int range = 2;

    [SerializeField]
    public LayerMask LayerMask;

    private List<GameObject> detects;

    private void Update()
    {
        detects = new List<GameObject>();
        var objs = Physics2D.OverlapCircleAll(transform.position, range, LayerMask);
        foreach (var obj in objs)
        {
            detects.Add(obj.gameObject);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position,range);

        if (detects == null)
        {
            return;
        }
        Gizmos.color = Color.green;
        foreach (var detect in detects)
        {
            Gizmos.DrawSphere(detect.transform.position,0.3f);
        }
    }
}
