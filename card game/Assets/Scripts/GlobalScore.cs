using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
    public static int currentScore;
    public GameObject scoreDisplay;
    public int highScore;
    public GameObject bestDisplay;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("BestScoreHiLo");
        bestDisplay.GetComponent<Text>().text = "BEST: " + highScore;
    }

    void Update()
    {
        scoreDisplay.GetComponent<Text>().text = "STREAK: " + currentScore;
        if (currentScore > highScore)
        {
            bestDisplay.GetComponent<Text>().text = "BEST: " + currentScore;
            PlayerPrefs.SetInt("BestScoreHiLo", currentScore);
        }
    }
}
