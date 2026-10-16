using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleStarter : MonoBehaviour
{
    /*ボタンが押されたらシーン移動*/
    public void OnPressedTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
