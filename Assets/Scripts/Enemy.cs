using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage;
    public int health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Player>().TakeDamage(damage);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0)
        {
            Destroy(gameObject);
        }
    }
}
