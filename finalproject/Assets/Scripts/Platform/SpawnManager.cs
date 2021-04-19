using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    PlatformSpawner platformSpawner;

    void Start()
    {
        platformSpawner = GetComponent<PlatformSpawner>();
    }

    public void SpawnTriggerEntered()
    {
        platformSpawner.MovePlatform();
    }
}
