using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StableBehavior : EnemyBehavior
{
    GameObject obj;

    public StableBehavior(GameObject obj)
    {
        this.obj = obj;
    }
    public void Behave()
    {
        obj.transform.Rotate(0, 0, 50 * Time.deltaTime);
    }
}
