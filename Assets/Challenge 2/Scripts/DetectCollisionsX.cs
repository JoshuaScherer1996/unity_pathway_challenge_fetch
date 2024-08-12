using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    // OnTrigger method the destroy the object on collision.
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
