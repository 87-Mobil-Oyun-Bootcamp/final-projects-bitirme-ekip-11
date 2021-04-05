using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform boomObj;

    Player player;
    GameObject playerObj;

    void Awake()
    {
        playerObj = GameObject.Find("Player");
        player = playerObj.GetComponent<Player>();
    }

    public void Damage()
    {
        player.SetDamage();
        Debug.Log("I got the damage");
    }

    private void OnTriggerEnter(Collider other)
    {
        Player comp = other.GetComponent<Player>();
        if (comp)
        {
            Instantiate(boomObj, transform.position, boomObj.rotation);
            //player.IncreaseStarScore();
            Destroy(gameObject);
            Debug.Log("BULLET !");
            Damage();
            Debug.Log("your energy: " + player.getEnergy());
        }

    }
}
