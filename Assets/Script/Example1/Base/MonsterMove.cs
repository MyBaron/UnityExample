using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
       GetComponent<Rigidbody2D>().velocity = Vector2.left;
    }
}
