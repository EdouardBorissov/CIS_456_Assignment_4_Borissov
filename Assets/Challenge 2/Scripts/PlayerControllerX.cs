using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Edouard Borissov
 * PlayerControllerX.cs
 * Assignment 4 
 * This code allows the player to spawn dogs.
 * */


public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float coolDown = 1f;
    private float currentTime = 0f;
    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && currentTime >= coolDown)
        {
            currentTime = 0f;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
