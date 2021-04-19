using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBehavior : EnemyBehavior
{
    GameObject obj;

    public RotatingBehavior(GameObject obj)
    {
        this.obj = obj;
    }
    public void Behave()
    {
        obj.transform.Rotate(0, 0, 50 * Time.deltaTime);
    }
}
