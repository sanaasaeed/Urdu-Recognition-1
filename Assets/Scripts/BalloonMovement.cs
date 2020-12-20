using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BalloonMovement : MonoBehaviour {
    //[SerializeField] public float speed = 10f;
    [SerializeField] private GameObject enemy;
    private GameState gameState;
    private Sprite target;
    private Rigidbody2D _rigidbody2D;
    private float yUpperLimit = 8;

    private void Start() {
        gameState = FindObjectOfType<GameState>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        enemy.GetComponent<SpriteRenderer>().sprite = gameState.letters[Random.Range(0, 37)];
    }

    private void Update() {
        if (transform.position.y > yUpperLimit) {
            Destroy(gameObject);
        }
        _rigidbody2D.AddForce(Vector2.up * Time.deltaTime, ForceMode2D.Impulse);
    }
    
    
}
