using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class encapsulation : MonoBehaviour
{
    private int health = 100;

    public void TakeDamage(int amount)
    {
        health -= 20;
    }

    public int getHealth()
    {
        return health;
    }

    public void resetHealth()
    {
        health = 100;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
