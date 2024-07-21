using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text Score;
    public static float scoreeee = 0;

    void Start()
    {
        
    }


    void Update()
    {
        if (PlayerScript.GameOver) return;

        scoreeee += (Time.deltaTime * 1.5f);
        Score.text = "" + (int)scoreeee;
    }
}
