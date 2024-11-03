using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDrop : MonoBehaviour
{
    // quick note idk what the variables in the code for the game is but
    // i assume you will be able to figure it out its not too complicated

    // enemy hp
    public float health = 50f;

    // prefab of a key
    public GameObject Key; 

    void EnemyOof()
    {
        if (health <= 0f)
        {
            // make prefab at location of enemy before enemy die
            Instantiate(Key, gameObject.transform.position, Quaternion.identity);
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
