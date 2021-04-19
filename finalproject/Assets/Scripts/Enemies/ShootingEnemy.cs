using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : Enemy
{

    [SerializeField]
    GameObject enemyObject;

    Player player;
    GameObject playerObj;

    void Awake()
    {
        behavior = new DynamicBehavior(enemyObject);
        playerObj = GameObject.Find("Player");
        player = playerObj.GetComponent<Player>();
    }

    void Update()
    {
        behavior.Behave(); 
    }

    public override void Damage()
    {
        player.SetDamage();
    }

    private void OnTriggerEnter(Collider other)
    {
        Player comp = other.GetComponent<Player>();
        if (comp)
        {
            Damage();
        }
      
    }
}
