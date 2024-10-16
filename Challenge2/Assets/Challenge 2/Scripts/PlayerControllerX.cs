using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogDelay = 20.0f;

    // Update is called once per frame
    void Update()
    {
        // Countdown delay timer every frame
        dogDelay = dogDelay - 0.1f;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && dogDelay < 1.0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            // Reset dogDelay
            dogDelay = 20.0f;
        }
    }
}
