using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject bullet;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
