using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    
    //[SerializeField]
    //GameObject starObject;

    public Transform boomObj;

    Player player;
    GameObject playerObj;

    void Awake()
    {
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
            //Object.Destroy(starObject);
            Destroy(gameObject);
            Debug.Log("your star score: " + player.getStarScore());
        }

    }

}
