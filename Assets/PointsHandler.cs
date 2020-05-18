using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointsHandler : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI oints;
    public Text scoreText;
    
    public void UpdatePoints ( int points)
    {
        scoreText.text = "Points: " + points.ToString();
    }

}
