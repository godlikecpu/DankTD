﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public static int highScore = 1;

    

    void Awake()
    {
        highScore = PlayerPrefs.GetInt("High Score", 0);
        TextMeshProUGUI text1 = gameObject.GetComponent<TextMeshProUGUI>();
        text1.text = "Lvl: TEST!" + highScore;
    }
    void Update()
    {
      //if gameOver, take level and set as highscore
    }
}
