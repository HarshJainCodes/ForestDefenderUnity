using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    // Start is called before the first frame update
    public int totalScore = 0;

    TextMeshProUGUI scoreLabel;
    void Start()
    {
        scoreLabel = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore()
    {
        totalScore += 10;
        scoreLabel.text = totalScore.ToString();
    }
}
