using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class PlayerCharacter : MonoBehaviour
{
    
    public int maxHealth = 100;
    int currentHealth; 

    void Start()
    {
        
        currentHealth = maxHealth;
       
    }

   
   
    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);

    }
}
