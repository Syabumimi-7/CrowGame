using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    /*速度*/
    public float Speed = 0.05f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(-1f*Speed, 0, 0);
    }
}
