using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Balloon : MonoBehaviour {
    [SerializeField] public float speed = 2f;
    [SerializeField] private GameObject enemy;
    private GameState gameState;
    private Sprite target;
    private Rigidbody2D _rigidbody2D;
    private float yUpperLimit = 8;

    private void Start() {
        gameState = FindObjectOfType<GameState>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        if (gameObject.CompareTag($"Enemy")) {
            gameState.letters.Remove(GameState.target);
            enemy.GetComponent<SpriteRenderer>().sprite = gameState.letters[Random.Range(0, 37)];
        }
        
    }

    private void Update() {
        if (transform.position.y > yUpperLimit) {
            Destroy(gameObject);
        }

        transform.Translate(Vector2.up * Time.deltaTime * speed);
        
        //_rigidbody2D.AddForce(Vector2.up * Time.deltaTime, ForceMode2D.Impulse);
    }

    private void OnMouseEnter() {
        if (gameObject.CompareTag("Target")) {
            Destroy(gameObject);
        }
    }
}
