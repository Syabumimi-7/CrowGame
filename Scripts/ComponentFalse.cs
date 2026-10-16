using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentFalse : MonoBehaviour
{
    [SerializeField] GameObject player;

    private float counter = 0;

    void Start()
    {
        player = GameObject.Find("Player");
        player.GetComponent<PlayerController>().enabled = false;
    }

    void Update()
    {
        counter += Time.deltaTime;

        if(counter>2.9f)
        {
            player.GetComponent<PlayerController>().enabled = true;
        }
    }
}
