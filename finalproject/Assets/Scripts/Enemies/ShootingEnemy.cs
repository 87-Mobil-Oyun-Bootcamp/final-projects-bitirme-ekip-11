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
        Debug.Log("I got the damage");
    }

    private void OnTriggerEnter(Collider other) // rigitbody ile çarpıştığında
    {
        Player comp = other.GetComponent<Player>();
        if (comp)
        {
            Damage();
            Object.Destroy(enemyObject);
        }
      
    }
}
