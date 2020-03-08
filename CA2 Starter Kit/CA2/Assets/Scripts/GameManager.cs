using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int numberOfZombies; //store number of zombies here
    ZombieHealth zombieHealth;
    public Text healthTextBox;
    public Text zombiesLeft;
    PlayerHealth playerHealth;
    void Awake()
    {

        //do not remove
        DontDestroyOnLoad(this);
        zombieHealth = GameObject.FindGameObjectWithTag("Zombie").GetComponent<ZombieHealth>();
        numberOfZombies = GameObject.FindGameObjectsWithTag("Zombie").Length;
        healthTextBox = GameObject.FindGameObjectWithTag("HealthText").GetComponent<Text>();
        zombiesLeft = GameObject.FindGameObjectWithTag("NoOfZombies").GetComponent<Text>();
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    private void Update()
    {
        healthTextBox.text = "Health: " + playerHealth.Health;
        zombiesLeft.text = "Zombies Left: " + numberOfZombies;
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
