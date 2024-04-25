using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsController : MonoBehaviour
{
    public TextMeshProUGUI textField;
    public BirdController birdController;
    public bool isHighscore;

    void Start()
    {
        textField.text = "0";        
    }

    void Update()
    {
        if (isHighscore)
        {
            textField.text = PlayerPrefs.GetInt("Highscore").ToString();
        }
        else
        {
            textField.text = birdController.Points.ToString();
        }
    }
}
