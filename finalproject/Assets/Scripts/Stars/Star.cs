using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    
    public Transform boomObj;
    //public GameObject star;
    private bool isCollected = false;

    Player player;
    GameObject playerObj;

    void Awake()
    {
        gameObject.GetComponent<Renderer>().enabled = true;
        playerObj = GameObject.Find("Player");
        player = playerObj.GetComponent<Player>();
    }

    void Update()
    {
        transform.Rotate(0, 0, 50 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) 
    {
        Player comp = other.GetComponent<Player>();
        if (comp)
        {
            Instantiate(boomObj, transform.position, boomObj.rotation);
            player.IncreaseStarScore();
            //Destroy(gameObject);
            gameObject.GetComponent<Renderer>().enabled = false;
            Debug.Log("your star score: " + player.getStarScore());
        }



    }

}
