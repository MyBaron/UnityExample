using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * 计算距离检测目标
 */
public class DetectTargetByDistance : MonoBehaviour
{
    public int range = 2;

    private List<GameObject> detects;

    private float time = 0;

    private void Update()
    {
        time -= Time.deltaTime;
        if (time>0)
        {
            time = 1;
            return;
        }
        
        detects = new List<GameObject>();
        var monsterList = CreateMonster.Instance.MonsterList;
        foreach (var monster in monsterList)
        {
            if (Vector2.Distance(gameObject.transform.position, monster.transform.position) < range)
            {
                detects.Add(monster);
            }
        }

        Debug.Log($"{detects.Count}");
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position,range);
        
        if(detects == null)
            return;
        
        Gizmos.color = Color.magenta;
        foreach (var detect in detects)
        {
            Gizmos.DrawSphere(detect.transform.position,0.3f);
        }
    }
}
