using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStart : MonoBehaviour
{
    public float speed; 

    private float counter = 0f;

    void Update()
    {
        counter += Time.deltaTime;

        if(counter<3f)
        {
            transform.Translate(speed, 0, 0);
        }
    }
}
