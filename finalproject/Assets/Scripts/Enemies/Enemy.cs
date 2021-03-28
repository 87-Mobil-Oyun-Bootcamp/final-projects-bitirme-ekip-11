using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public EnemyBehavior behavior;

    void PerformBehavior() 
    {
        behavior.Behave();
    }
    public abstract void Damage();
}
