using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FadeManager : MonoBehaviour
{
/*	SpriteRenderer sp; 
    Color spriteColor;
    float duration = 1f;

	void Start()
	{
		sp = GetComponent();
        spriteColor = sp.color;
		StartCoroutine(Fade(0));
	}

	IEnumerator Fade(float targetAlpha)
    {
        while (!Mathf.Approximately(spriteColor.a, targetAlpha))
        {
            float changePerFrame = Time.deltaTime / duration;
            spriteColor.a = Mathf.MoveTowards(spriteColor.a, targetAlpha, changePerFrame);
            sp.color = spriteColor;
            yield return null;
        }
    }*/

    [SerializeField] private TextMeshProUGUI Aim;
	[SerializeField] private TextMeshProUGUI Number;

	void Start()
	{
//		for(counter=0; counter<3; counter++)
//		{
			StartCoroutine(Fade(Number));
			StartCoroutine(AimFade(Aim));
//		}
	}

/*	void Update()
	{
		
	}*/

	private IEnumerator Fade(TextMeshProUGUI _obj)
	{
		for(int counter=4; counter>0; counter--)
		{
			if(counter >= 2)
			{
				Number.text = (counter-1).ToString("D1");
			}
			else
			{
				Number.text = ("GO!");
			}
			bool flag = true;
			float a_col = 1;
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

	private IEnumerator AimFade(TextMeshProUGUI _obj)
	{
			bool flag = true;
			float a_col = 3;
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

/*	private IEnumerator Appear(TextMeshProUGUI _obj)
	{
		float a_col = 1;
		var colortemp = _obj.color;
		_obj.color = new Color(colortemp.r, colortemp.g, colortemp.b, a_col);
	}*/

}

