using System.Collections;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class colllisionHandler : MonoBehaviour
{
    GameObject score;
    UpdateScore score_script;


    private void Start()
    {
        score = GameObject.Find("Score");
        score_script = score.GetComponent<UpdateScore>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);

            score_script.IncreaseScore();
            
        }
    }
}
