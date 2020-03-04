using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 2;
    public int damage = Random.Range(25, 75); //random damage

    private void Start()
    {
        Invoke("DestroyBullet", 2);
    }

    //sets the velocity of the bullet
    public void SetDirection(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = direction * Speed;
    }

    //can be extended by later (virtual)
    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
        DestroyBullet();
    }

    //can be extended by later (virtual)
    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBullet();
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
    void ApplyDamagetoHealth(GameObject entityStruck)
    {
        HealthComponent entityHealthComponent = entityStruck.GetComponent<HealthComponent>(); // Storing the HealthComponent script into entityHealthComponent
        if(entityHealthComponent)
        {
            entityHealthComponent.ApplyDamage(damage);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ApplyDamagetoHealth(collision.gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        ApplyDamagetoHealth(other.gameObject);
    }

}
