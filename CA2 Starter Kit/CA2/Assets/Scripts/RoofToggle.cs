using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofToggle : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // get sprite renderer
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Vehicle")) //if collides with player or vehic;le
        {
            spriteRenderer.enabled = false; //disable renderer
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Vehicle"))
        {
            spriteRenderer.enabled = true; //enable renderer
        }
    }


}
