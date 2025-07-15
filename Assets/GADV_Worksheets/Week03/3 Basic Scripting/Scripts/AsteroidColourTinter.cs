using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidColourTinter : MonoBehaviour
{
   bool aSwitch = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            aSwitch = !aSwitch;

            if (aSwitch == true)
            {
                // Access the SpriteRenderer component
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

                // Change the color to blue
                spriteRenderer.color = Color.blue;
            }
            else
            {
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
                spriteRenderer.color = Color.white;
            }
        }
    }
}

