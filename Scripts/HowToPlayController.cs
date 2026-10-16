using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HowToPlayController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI First;

	void Start()
	{
		StartCoroutine(FirstFade(First));
	}

    private IEnumerator FirstFade(TextMeshProUGUI _obj)
	{
		for(int counter=6; counter>0; counter--)
		{
			if(counter == 6)
			{
				First.text = ("マウスを動かしてカラスを動かしましょう。");
			}
            if(counter == 5)
			{
				First.text = ("カラスが爆弾に当たるとダメージを受けます。");
			}
            if(counter == 4)
			{
				First.text = (" ");
			}
            if(counter == 3)
			{
				First.text = ("爆弾に3回当たるとゲームオーバーです。");
			}
            if(counter == 2)
			{
				First.text = ("爆弾に当たらないように気を付けましょう。");
			}
            if(counter == 1)
			{
				First.text = ("ゴールテープを通ればクリアです。");
			}
			bool flag = true;
			float a_col = 4;
			var colortemp = _obj.color;
			while (flag)
			{
				_obj.color = new Color(colortemp.r, colortemp.g, colortemp.b, a_col);
				a_col -= Time.deltaTime;
				yield return new WaitForEndOfFrame();
				if (a_col < 0)
				{
					a_col = 0;
					flag = false;
				}
			}
		}
	}
}
