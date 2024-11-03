using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    // attach this script to the trigger you want to activate this script, like a door

    void OnTriggerEnter(Collider other)
    {
        if (hasKey == true)
        {
            SceneManager.GetActiveScene().buildIndex + 1;
            hasKey = false;
        }
    }
}
