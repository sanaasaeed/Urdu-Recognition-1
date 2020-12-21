using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameState : MonoBehaviour {
    public static Sprite target;
    public static int score;
    [SerializeField] private GameObject targetLetter;
    [SerializeField] public List<Sprite> letters;
    [SerializeField] private TextMeshProUGUI scoreText;
    
    private void OnEnable() {
        SetTargetAlphabet();
        //setGameScore();
    }

    private void SetLevelScore() {
        
    }

    public  void IncreaseScore() {
        score += 10;
        scoreText.text = score.ToString();
    }
    
    public void DecreaseScore() {
        score -= 10;
        scoreText.text = score.ToString();
    }

    public void SetTargetAlphabet() {
        target = letters[Random.Range(0, 37)];
        targetLetter.GetComponent<SpriteRenderer>().sprite = target;
    }
}
