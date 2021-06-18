using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting1 : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefeb;

    public float bulletForce = 20f;

    void Update()
    {
        if(Input.GetButtonDown("space"))
        {
            Shoot();
        }
        
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefeb, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce();
    }
}