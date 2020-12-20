using System;
using UnityEngine;

public class BalloonMovement : MonoBehaviour {
    //[SerializeField] public float speed = 10f;
    private Rigidbody2D _rigidbody2D;

    private void Start() {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        _rigidbody2D.AddForce(Vector2.up * Time.deltaTime, ForceMode2D.Impulse);
    }
}
