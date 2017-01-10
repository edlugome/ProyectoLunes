using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour 
{
	public Image EBackground;

	IEnumerator ColorTransition()
	{
		while (EBackground.color.r < EBackground.color.r * 3) 
		{
			
			yield return new WaitForSeconds (0.05f);
		}
	}


}
