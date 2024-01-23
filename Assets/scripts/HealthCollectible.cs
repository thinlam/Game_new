using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {

        PlayerCharacter character = other.GetComponent<PlayerCharacter>();

        if (character != null && character.health<character.maxHealth)
        {
            character.ChangeHealth(1);
            Destroy(gameObject);
        }
    }

}
