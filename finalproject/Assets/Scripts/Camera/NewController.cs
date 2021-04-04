using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 6, -10);

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
