using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Edouard Borissov
 * SpawnManagerX.cs
 * Assignment 4
 * This code spawns balls in a random location in random intervals.
 * */



public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }



    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        index = Random.Range(0, 2);



        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);



        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);

        spawnInterval = Random.Range(3, 5);
    }

}
