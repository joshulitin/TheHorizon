using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Healthbar : MonoBehaviour
{
	public Image currentHealthBar;
	public Text ratioText;

	public GameObject youFell;
	public GameObject fadeOut;

	public GameObject pauseButton;
	public GameObject joystickController;
	public GameObject joystickJump;
	
	Animator Animator;

	private float hitpoint = 150;
	private float maxhitpoint = 150;

	private void Start()
	{
		UpdateHealthBar();
		Animator = GetComponentInChildren<Animator>();
	}

	private void UpdateHealthBar()
	{
		float ratio = hitpoint / maxhitpoint;
		currentHealthBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
		ratioText.text = (ratio * 100).ToString("0") + '%';
	}

	private void TakeDamage(float damage)
	{
		hitpoint -= damage;
		
		if(hitpoint < 0)
		{
			hitpoint = 0;
			Animator.SetBool("isDead", true);
			pauseButton.SetActive(false);
			joystickController.SetActive(false);
			joystickJump.SetActive(false);
			StartCoroutine(YouFellOff());
		}

		UpdateHealthBar();
	}

	private void HealDamage(float heal)
	{
		hitpoint += heal;
		if (hitpoint > 0)
		{
			hitpoint = maxhitpoint;
			
		}

		UpdateHealthBar();
	}
	
	IEnumerator YouFellOff()
	{
		
		youFell.SetActive(true);

		yield return new WaitForSeconds(2);
		fadeOut.SetActive(true);
		yield return new WaitForSeconds(1);
		GlobalScore.currentScore = 0;
		SceneManager.LoadScene(RedirectToLevel.redirectToLevel);
	}
}
