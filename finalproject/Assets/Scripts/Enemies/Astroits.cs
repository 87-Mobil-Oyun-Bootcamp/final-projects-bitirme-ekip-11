using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroits : Enemy
{

    [SerializeField]
    GameObject enemyObject;

    public Transform boomObj;

    Player player;
    GameObject playerObj;

    void Awake()
    {
        behavior = new RotatingBehavior(enemyObject);
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
    
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "PlayerBody")
        {
            Instantiate(boomObj, transform.position, boomObj.rotation);
            StartCoroutine("WaitForParticle");
        }
    }

    IEnumerator WaitForParticle()
    {
        yield return (new WaitForSeconds(0.3f));
        Damage();
    }
}
