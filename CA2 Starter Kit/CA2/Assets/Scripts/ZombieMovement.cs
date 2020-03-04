using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    GameObject player;
    public int movementSpeed = 100;
    public int trackingRange = 5;
    Rigidbody2D zombie;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        zombie = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        zombie.transform.LookAt(player.transform);
         = 0;
    }
}
