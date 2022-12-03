using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMover : MonoBehaviour
{
    // Start is called before the first frame update
    float left_speed = -10f;
    float right_speed = 10f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(left_speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(right_speed * Time.deltaTime, 0, 0));
        }

        Vector3 newPos = new Vector3(Mathf.Clamp(transform.position.x, -8, 3), transform.position.y, 0);

        transform.position = newPos;
    }
}
