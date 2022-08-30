using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMonster : MonoBehaviour
{
  [SerializeField]
  private Vector2 position;
  [SerializeField]
  private GameObject monsterPerfab;

  private float _createTime = 0;

  public List<GameObject> MonsterList { get; } = new List<GameObject>();

  public static CreateMonster Instance { get; set; }

  private void Awake()
  {
    Instance = this;
  }

  private void Update()
  {
    _createTime += Time.deltaTime;
    if (_createTime > 2)
    {
      _createTime = 0;
      MonsterList.Add(Instantiate(monsterPerfab, position, new Quaternion(0, 180, 0, 1)));
    }
  }
}
