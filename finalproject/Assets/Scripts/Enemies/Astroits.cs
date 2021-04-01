using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroits : Enemy
{

    [SerializeField]
    GameObject enemyObject;

    Player player;
    GameObject playerObj;

    void Awake()
    {
        behavior = new StableBehavior(enemyObject);
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

    
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "PlayerBody")
        {
            Debug.Log("COLLISION");
            Damage();
            Debug.Log("your energy: " + player.getEnergy());
        }
    }
}
