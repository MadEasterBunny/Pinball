using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public GameObject scoreText;

    private int score;

    public int smallStarPoints;
    public int largeStarPoints;
    public int smallCloudPoints;
    public int largeCloudPoints;

	// Use this for initialization
	void Start ()
    {
        this.scoreText = GameObject.Find("Score");
        score = 0;
        ScoreText();
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("SmallStarTag"))
        {
            score = score + smallStarPoints;
            ScoreText();
        }
        else if (other.gameObject.CompareTag("LargeStarTag"))
        {
            score = score + largeStarPoints;
            ScoreText();
        }
        else if (other.gameObject.CompareTag("SmallCloudTag"))
        {
            score = score + smallCloudPoints;
            ScoreText();
        }
        else if (other.gameObject.CompareTag("LargeCloudTag"))
        {
            score = score + largeCloudPoints;
            ScoreText();
        }
    }

    void ScoreText()
    {
        this.scoreText.GetComponent<Text>().text = "Score: " + score.ToString();
    }
}
