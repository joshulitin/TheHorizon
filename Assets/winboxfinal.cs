using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winboxfinal : MonoBehaviour
{
	private void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player")
		{
			LevelManager.Instance.FinalVictory();
		}
	}
}
