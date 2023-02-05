using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medkit : MonoBehaviour
{
	[SerializeField] private int healAmount;
	private void OnTriggerEnter(Collider collider)
	{
		MyScript player = collider.GetComponent<MyScript>();
		if (player != null)
		{
			player.Heal(healAmount);
		}
	}
}
