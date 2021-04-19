using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Player player;
    GameObject playerObj;

    public Transform boomObj;

    void Awake()
    {
        playerObj = GameObject.Find("Player");
        player = playerObj.GetComponent<Player>();
    }

    public void Damage()
    {
        player.SetDamage();
    }

    private void OnTriggerEnter(Collider other)
    {
        Player comp = other.GetComponent<Player>();
        if (comp)
        {
            Instantiate(boomObj, transform.position, boomObj.rotation);
            Destroy(gameObject);
            Damage();
        }
    }
}
