using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStarter_3 : MonoBehaviour
{
    /*ボタンが押されたらシーン移動*/
    public void OnPressedThree()
    {
        SceneManager.LoadScene("GameScene_3");
    }
}
