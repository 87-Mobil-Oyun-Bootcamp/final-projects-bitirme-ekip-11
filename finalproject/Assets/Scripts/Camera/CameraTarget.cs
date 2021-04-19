using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    public static int movespeed = 1;
    
    public void Update()
    {
        transform.Translate(transform.forward * 10 * Time.deltaTime, Space.World);
    }
}
