using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CreateMonster : MonoBehaviour
{
    [SerializeField]
    private Vector2 postion;

    [SerializeField]
    private GameObject monster;

    private float _createTime;

    public List<GameObject> MonsterList = new List<GameObject>();
    
    public static CreateMonster Instance { get; set; }

    private void Start()
    {
        Instance = this;
    }

    private void Update()
    {
        _createTime += Time.deltaTime;
        if (_createTime >= 2)
        {
            _createTime = 0;
            var monsterGameObject = Instantiate(monster, postion, new Quaternion(0, 180, 0, 1));
            MonsterList.Add(monsterGameObject);
        }
    }
}
