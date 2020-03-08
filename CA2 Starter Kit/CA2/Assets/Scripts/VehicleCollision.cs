using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleCollision : MonoBehaviour
{
    ZombieHealth zombieHealthScript; //making a variable to store the health script with a data type of zombiehealth
    



    private void OnCollisionEnter2D(Collision2D collision)
    {
        zombieHealthScript = GameObject.FindGameObjectWithTag("Zombie").GetComponent<ZombieHealth>();
        if (collision.gameObject.CompareTag("Zombie"))
        {
            
            zombieHealthScript.KillCharacter();
        }
    }
}
