using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	public float speed;
	public float lifeTime;
	public GameObject destroyEffect;
	public float distance;
	public LayerMask whatIsSolid;
	public int damage;
	// Start is called before the first frame update
	void Start()
	{
		Invoke("DestroyProjectile", lifeTime);

	}

	// Update is called once per frame
	void Update()
	{
		//RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance,whatIsSolid);
		//if(hitInfo.collider != null)
		//{
		//	if(hitInfo.collider.CompareTag("Enemy"))
		//	{
		//		Debug.Log("Enemy must take damage");
		//		hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
		//	}
		//	DestroyProjectile();
		//}
		//transform.Translate(transform.up * speed * Time.deltaTime);
		RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
		if (hitInfo.collider != null)
		{
			if (hitInfo.collider.CompareTag("Enemy"))
			{
				hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
			}
			DestroyProjectile();
		}


		transform.Translate(Vector2.up * speed * Time.deltaTime);
	}
	void DestroyProjectile()
	{
		Instantiate(destroyEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		// neu fireball cham vao player thi player se nhan sat thuong
		if (collision.tag == "Enemy")
		{
			collision.GetComponent<Player>().TakeDamage(damage);
		}

		Destroy(gameObject);
	}
}
