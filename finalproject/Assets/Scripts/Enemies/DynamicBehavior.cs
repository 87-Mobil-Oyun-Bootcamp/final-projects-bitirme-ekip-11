using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicBehavior : EnemyBehavior
{
    public float min = 2f;
    public float max = 3f;
    private float num;
    GameObject obj;

    public DynamicBehavior(GameObject obj)
    {
        this.obj = obj;
        min = obj.transform.position.y;
        max = obj.transform.position.y + 3;
        num = UnityEngine.Random.Range(0, 4f);
    }

    public void Behave()
    {
        obj.transform.position = new Vector3(obj.transform.position.x, Mathf.PingPong(Time.time * num, max - min) + min, obj.transform.position.z);
    }

    

}
