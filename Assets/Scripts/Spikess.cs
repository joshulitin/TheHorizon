using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikess : MonoBehaviour
{
	[SerializeField] private int damageAmount;
	private void OnTriggerEnter(Collider collider)
	{
		MyScript player = collider.GetComponent<MyScript>();
		if (player != null)
		{
			player.takeDamage(damageAmount);
		}
	}
}
