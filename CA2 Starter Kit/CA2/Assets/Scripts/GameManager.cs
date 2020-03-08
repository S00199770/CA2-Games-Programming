using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int numberOfZombies; //store number of zombies here
    ZombieHealth zombieHealth;
    void Awake()
    {
        //do not remove
        DontDestroyOnLoad(this);
        zombieHealth = GameObject.FindGameObjectWithTag("Zombie").GetComponent<ZombieHealth>();
        numberOfZombies = GameObject.FindGameObjectsWithTag("Zombie").Length;

    }

    private void Update()
    {
        
    }

    public void RecordZombieDeath() //method to call when killing a zombie
    {
        if(true)
        {
            numberOfZombies--; // subtract from total number of zombies
        }
        
        if(numberOfZombies <= 0)
        {
            SceneManager.LoadScene("GameComplete");
        }
    }
}
