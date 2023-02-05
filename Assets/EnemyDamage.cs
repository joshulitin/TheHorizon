using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
	public bool isDamaging;
	public float damage = 10;

	private void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player")
			col.SendMessage((isDamaging) ? "TakeDamage" : "HealDamage", Time.deltaTime * damage);
	}


	
}
