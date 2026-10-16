using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject HP;

    void Start()
    {
        Application.targetFrameRate = 60;  

        this.HP = GameObject.Find("HP");

        Debug.Log("Good Morning! Unity!");
    }

    /*呼び出されたらHPバーを三分の一減らす*/
    public void DecreaseHP()
    {
        this.HP.GetComponent<Image>().fillAmount -= 0.333f;
    }
}
