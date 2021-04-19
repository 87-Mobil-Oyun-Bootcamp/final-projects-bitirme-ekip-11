using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    [SerializeField]
    private Transform firePoint;
    [SerializeField]
    private Rigidbody prefab;

    private Rigidbody bullet;
    private float force = 500f;

    void Start()
    {
        InvokeRepeating("Spawn", 2, 1);
    }

    void Spawn()
    {
        bullet = Instantiate(prefab, firePoint.position, firePoint.rotation);
        bullet.AddForce(firePoint.forward * force);
        bullet.velocity = transform.TransformDirection(0, 0, 40);
    }
}
