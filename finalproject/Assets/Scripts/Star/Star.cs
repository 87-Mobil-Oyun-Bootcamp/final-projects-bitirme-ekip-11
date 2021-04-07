using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    
    public Transform boomObj;
  
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
            Debug.Log("STAR");
            Instantiate(boomObj, transform.position, boomObj.rotation);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Player comp = other.GetComponent<Player>();
        if (comp)
        {
            player.IncreaseStarScore();
            Debug.Log("star on trigger exit: ");
            Debug.Log(player.getStarScore().ToString());
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }

}
