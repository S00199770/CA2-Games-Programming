using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int numberOfZombies; //store number of zombies here
    void Awake()
    {
        //do not remove
        DontDestroyOnLoad(this);

        numberOfZombies = GameObject.FindGameObjectsWithTag("Zombie").Length; 
    }

    private void Update()
    {
    }

    public void RecordZombieDeath() //method to call when killing a zombie
    {
        numberOfZombies = numberOfZombies - 1; // subtract from total number of zombies
        if(numberOfZombies <= 0)
        {
            SceneManager.LoadScene("GameComplete");
        }
    }
}
