using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStarter_2 : MonoBehaviour
{
    /*ボタンが押されたらシーン移動*/
    public void OnPressedTwo()
    {
        SceneManager.LoadScene("GameScene_2");
    }
}
