using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    GameObject player;
    public int movementSpeed = 50;
    public int trackingRange = 5;
    Rigidbody2D zombie;
    public int rotationSpeed = 5;
    private Vector2 movement;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        zombie = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //RotateTowards();
        //MoveTowardsPlayer();

        Vector3 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        zombie.rotation = angle;
        direction.Normalize();
        movement = direction;
        


    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction)
    {
        if (Vector3.Distance(transform.position, player.transform.position) <= trackingRange)
        {
            zombie.MovePosition((Vector2)transform.position + (direction * (movementSpeed * Time.deltaTime)));
        }
        
    }
    
    
    /* private void RotateTowards()
    {
        Vector3 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        zombie.rotation = angle;
    } */
    /* private void MoveTowardsPlayer()
    {
        Vector2 distance = new Vector2(player.transform.position.x - zombie.position.x, player.transform.position.y - zombie.position.y);
        distance = distance.normalized;
        if (Vector3.Distance(gameObject.transform.position, player.transform.position)<= trackingRange) //if the Vector of the Zombie and the Vector of Player are less than 5 apart (imagine on a graph)
        {
            zombie.MovePosition(distance);
        }
    } */
}
