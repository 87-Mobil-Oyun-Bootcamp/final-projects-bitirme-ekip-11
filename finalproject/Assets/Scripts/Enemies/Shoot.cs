using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private Transform firePoint;

    [SerializeField]
    private Rigidbody projectilePrefab;

    [SerializeField]
    private float launchForce = 700f;

    
    void Start()
    {  

    }

    // Update is called once per frame
  public void FixedUpdate()
    {
           
           LaunchProjectile();
         
         

    }

    private void LaunchProjectile()
    {
        var projectileInstane = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

        projectileInstane.AddForce(firePoint.forward * launchForce);

       
    }
   
}
