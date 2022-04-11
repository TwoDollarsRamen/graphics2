using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoThing : MonoBehaviour
{
	public void DoAThing()
	{
		GetComponent<Animator>().Play("die", -1, 0.0f);
	}
}
