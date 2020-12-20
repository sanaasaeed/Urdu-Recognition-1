using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameState : MonoBehaviour {
    public static Sprite target;
    [SerializeField] private GameObject targetLetter;
    [SerializeField] private List<Sprite> letters;
    
    private void OnEnable() {
        SetTargetAlphabet();
        setGameScore();
    }

    private void setGameScore() {
        throw new NotImplementedException();
    }

    private void SetTargetAlphabet() {
        target = letters[Random.Range(0, 37)];
        targetLetter.GetComponent<SpriteRenderer>().sprite = target;
    }
}
