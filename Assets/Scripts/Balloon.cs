using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Balloon : MonoBehaviour {
    [SerializeField] public float speed = 2f;
    [SerializeField] private GameObject enemyLetter;
    private GameState gameState;
    private Sprite target;
    private AudioManager audioManager;
    private Rigidbody2D _rigidbody2D;
    private float yUpperLimit = 8;

    private void Start() {
        gameState = FindObjectOfType<GameState>();
        audioManager = FindObjectOfType<AudioManager>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        if (gameObject.CompareTag($"Enemy")) {
            gameState.letters.Remove(GameState.target);
            enemyLetter.GetComponent<SpriteRenderer>().sprite = gameState.letters[Random.Range(0, 37)];
        }
        else if(gameObject.CompareTag($"Target")) {
            
        }
        
    }

    private void Update() {
        if (transform.position.y > yUpperLimit) {
            Destroy(gameObject);
        }

        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }

    private void OnMouseEnter() {
        if (gameObject.CompareTag("Target")) {
            gameState.IncreaseScore();
            audioManager.PlayCorrectAudio();
            Destroy(gameObject);
        }

        if (gameObject.CompareTag("Enemy")) {
            gameState.DecreaseScore();
            audioManager.PlayWrongAudio();
        }
    }
}
