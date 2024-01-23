using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class PlayerCharacter : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    public float speed = 6.0f;
    public int maxHealth = 100;
    Vector2 move;
    public InputAction MoveAction;
    int currentHealth; 
    public int health { get { return currentHealth; } }

    void Start()
    {
        MoveAction.Enable();
        rigidbody2D = GetComponent<Rigidbody2D>();
        //currentHealth = maxHealth;
       
    }

    void Update()
    {
        move = MoveAction.ReadValue<Vector2>();
        
    }

    void FixedUpdate()
    {
        Vector2 position = (Vector2)rigidbody2D.position + move * speed * Time.deltaTime;
        rigidbody2D.MovePosition(position);
    }

    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);

    }
}
