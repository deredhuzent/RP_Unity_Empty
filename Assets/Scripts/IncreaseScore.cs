using UnityEngine;
using UnityEngine.UI;

public class IncreaseScore : MonoBehaviour
{
    public Text myScore;

    [SerializeField]
    private int score = 0;
    void Awake()
    {
        myScore.text = "Score: 0";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        myScore.text = "Score: " + score;
    }
}
