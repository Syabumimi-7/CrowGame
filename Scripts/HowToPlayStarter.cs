using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlayStarter : MonoBehaviour
{
    /*ボタンが押されたらシーン移動*/
    public void OnPressedHowToPlay()
    {
        SceneManager.LoadScene("HowToPlayScene");
    }
}
