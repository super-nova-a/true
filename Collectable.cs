using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    bool hit = false; 
    public bool hasKey = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.CompareTag("Player")) // only if Player tag, then
        {
            hit = true;
        }
    }

    void Update()
    {
        if (hit == true)
        {
            Destroy(gameObject);
            hasKey = true;
        }
    }
}
