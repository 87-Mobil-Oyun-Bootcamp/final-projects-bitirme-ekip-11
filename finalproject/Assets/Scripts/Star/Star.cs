using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public bool Hide = false;
    public Transform boomObj;
    bool isAble;
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
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Player comp = other.GetComponent<Player>();
        if (comp)
        {
            player.IncreaseStarScore();
            //gameObject.GetComponent<Renderer>().enabled = false;
            isAble = gameObject.GetComponent<Renderer>().enabled;
            if (isAble)
            {
                gameObject.GetComponent<Renderer>().enabled = false;
                StartCoroutine("WaitUnhide");
            }
        }
    }


    IEnumerator WaitUnhide()
    {
        yield return (new WaitForSeconds(2));
        gameObject.GetComponent<Renderer>().enabled = true;
    }

}
