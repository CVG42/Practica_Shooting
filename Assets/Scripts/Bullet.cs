using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float dmg;

    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        if (transform.position.x <= -11.9 || transform.position.x >= 11.9)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            collision.GetComponent<Enemy>().TakeDmg(dmg);
            Destroy(gameObject);
        }
        if (collision.CompareTag("Limit"))
        {
            Destroy(gameObject);
        }
    }


}
