using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    private GameObject pipes;
    [Header("Spawning")]
    [SerializeField]
    private float timeSpawn;
    [SerializeField]
    private float delaySpawn;

    Vector2 location;

    private void Update()
    {
        InvokeRepeating("spawnPipes", timeSpawn, delaySpawn);
    }

    private void spawnPipes()
    {
        location = new Vector2(9, UnityEngine.Random.Range(-3.20f, 2.40f));

        Instantiate(pipes, location, Quaternion.identity);
    }
}
