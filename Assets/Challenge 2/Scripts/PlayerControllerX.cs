using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    // This is the time interval required for the player to be able to spawn another dog
    private float dogRespawnTime = 2.0f;

    // The "preTime" has been initiallized in a way to allow the "dogRespawnTime" to take effect after spawning the dog for the first time
    private float preTime = -2.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - preTime > dogRespawnTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            preTime = Time.time;
        }
    }
}
