using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    // Playerの速度
    public static float manualSpeed = 0.008f;

    // Sliderを操作
    Slider crowSlider;

    void Start()
    {
        // Sliderのコンポーネントを取得
        crowSlider = GetComponent<Slider>();

        // Sliderの変更を保存
        crowSlider.value = manualSpeed; 
    }

    public void ChangeFeeling()
    {
        //Debug.Log("Hello");

        // manualSpeedを変更
        manualSpeed = crowSlider.value;
    }
}
