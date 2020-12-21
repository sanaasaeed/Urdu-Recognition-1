using UnityEngine;

public class GoalsScreen : MonoBehaviour {
    public static bool isGoalsScreenOpened = true;
    [SerializeField] private GameObject goalsScreen;
    [SerializeField] private GameObject targetLetter;
    //private GameState gameState;

    /*
    private void OnEnable() {
        gameState = FindObjectOfType<GameState>();
        gameState.SetTargetAlphabet();
    }*/

    private void Start() {
        Time.timeScale = 0f;
        targetLetter.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
        Instantiate(targetLetter, new Vector2(0,0), targetLetter.transform.rotation);
        
    }

    public void CloseGoalsScreen() {
        Time.timeScale = 1f;
        if (isGoalsScreenOpened) {
            goalsScreen.SetActive(false);
        }
    }
}
