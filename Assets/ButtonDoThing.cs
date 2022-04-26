using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoThing : MonoBehaviour
{
	public void Die()
	{
		GetComponent<Animator>().SetBool("dead", true);
	}

	public void Revive()
	{
		GetComponent<Animator>().SetBool("dead", false);
	}

	public void RandomiseColours()
	{
		foreach (var mesh in gameObject.GetComponentsInChildren<SkinnedMeshRenderer>())
		{
			for (int i = 0; i < mesh.materials.Length; i++)
			{
				var material = mesh.materials[i];

				material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
			}
		}
	}
}
