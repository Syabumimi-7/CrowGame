using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStarter_1 : MonoBehaviour
{
    /*ボタンが押されたらシーン移動*/
    public void OnPressed()
    {
        SceneManager.LoadScene("GameScene_1");
    }
}
