using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    GameObject playerObj;
    Player player;
    
    public Transform boomObj;
    public bool Hide = false;
    
    private bool isAble;
    
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
            isAble = gameObject.GetComponent<Renderer>().enabled;

            if (isAble)
            {
                gameObject.GetComponent<Renderer>().enabled = false;
                StartCoroutine("WaitToUnhide");
            }
        }
    }

    IEnumerator WaitToUnhide()
    {
        yield return (new WaitForSeconds(2));
        gameObject.GetComponent<Renderer>().enabled = true;
    }
}
