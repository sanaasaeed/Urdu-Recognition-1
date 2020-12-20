using System;
using UnityEngine;

public class BalloonMovement : MonoBehaviour {
    //[SerializeField] public float speed = 10f;
    private Sprite target;
    private Rigidbody2D _rigidbody2D;
    private float yUpperLimit = 8;

    private void Start() {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        if (transform.position.y > yUpperLimit) {
            Destroy(gameObject);
        }
        _rigidbody2D.AddForce(Vector2.up * Time.deltaTime, ForceMode2D.Impulse);
    }
}
