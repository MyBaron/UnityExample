
using System.Collections.Generic;
using UnityEngine;

/*
 * 依靠物理射线检测目标
 */
public class DetectTargetByPhysics : MonoBehaviour
{
    /*检测范围*/
    public int range = 2;

    [Header("检测图层")]
    [SerializeField]
    public LayerMask layerMask;

    /*检测到的对象*/
    private List<GameObject> detect ;
    
    void Update()
    {
        detect = new List<GameObject>();
        var objColliders = Physics2D.OverlapCircleAll(transform.position,range,layerMask);
        foreach (var monster in objColliders)
        {
                detect.Add(monster.gameObject);
        }
    }
    
    
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);

        if (detect == null)
            return;
        Gizmos.color = Color.magenta;
        foreach (var item in detect)
        {
            Gizmos.DrawSphere(item.transform.position, 0.3f);
        }
    }
}
