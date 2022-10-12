using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float HP;
    [SerializeField] private GameObject deathEffect;

    public void TakeDmg(float dmg)
    {
        HP -= dmg;
        if(HP <=0)
        {
            Death();
        }
    }

    private void Death()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
