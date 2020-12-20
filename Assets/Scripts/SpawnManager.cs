﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    [SerializeField] public List<GameObject> spawningObjects;
    [SerializeField] public float xRange = 5f;
    private float delay = 2;
    private  float interval = 1f;
    private float yPos =-8;
    
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomBalloons), delay, interval);
    }

    void SpawnRandomBalloons() {
        int index = Random.Range(0, spawningObjects.Count);
        Vector2 spawnPos = new Vector2(Random.Range(-xRange, xRange), yPos);
        Instantiate(spawningObjects[index], spawnPos, spawningObjects[index].transform.rotation);
    }
}
