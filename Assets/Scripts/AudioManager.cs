using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update

    AudioSource audioS;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        audioS = GetComponent<AudioSource>();
        //audioS.Play();
    }

    // Update is called once per frame
    void Update()
    {
           
    }
}
