using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    private float startX;
    private float lastX;
    private float startY;
    private float lastY;
    private float distanceX;
    private float distanceY;
    private float moveValueX;
    private float moveValueY;
    public SpawnManager spawnManager;
    public float  speed=10f;

    void Update()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);

        if (Input.GetMouseButtonDown(0))
        {
            startX = Input.mousePosition.x;
            startY = Input.mousePosition.y;

        }
        else if (Input.GetMouseButton(0))
        {
            lastX = Input.mousePosition.x;
            distanceX = lastX - startX;
            moveValueX = (distanceX / Screen.width) * 50;

            lastY = Input.mousePosition.y;
            distanceY = lastY - startY;
            moveValueY = (distanceY / Screen.height) * 50;

            transform.position = new Vector3(Mathf.Clamp(transform.position.x + moveValueX, -5, 5), Mathf.Clamp(transform.position.y + moveValueY, -5, 6), transform.position.z);

            startX = lastX;
            startY = lastY;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.root.gameObject.CompareTag("Platform"))
        {
            spawnManager.SpawnTriggerEntered();
            Debug.Log("platform spawned!");
        }


    }
}
