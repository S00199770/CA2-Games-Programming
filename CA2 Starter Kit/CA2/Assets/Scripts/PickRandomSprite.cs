using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickRandomSprite : MonoBehaviour
{
    public Sprite[] possibleSprites; //array of sprites
    int rnd;
    void Start()
    {
        rnd = Random.Range(0, 4); //random 5 numbers
        pickRandomSprite();
    }
    public void pickRandomSprite() //method to assign random sprite
    {
        //depending on the number given in the start, assign the sprite of the vehicle to be the index of the array that is the same as the random number generatedd
        if(rnd == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = possibleSprites[0];
        }
        else if (rnd == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = possibleSprites[1];
        }
        else if (rnd == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = possibleSprites[2];
        }
        else if (rnd == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = possibleSprites[3];
        }
        else if (rnd == 4)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = possibleSprites[4];
        }
    }
}
