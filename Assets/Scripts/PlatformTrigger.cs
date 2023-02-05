using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{
	public GameObject DoorPlatform;
	// public GameObject Door;
	public bool alreadyTriggered;
	public GameObject questionPanel;
	public GameObject decoyButton;

	void OnTriggerEnter()
	{	
		if (!alreadyTriggered)
		{
			// Door.GetComponent<Animation>().Play("DoorAnim");
		
			DoorPlatform.GetComponent<Animation>().Play("PlatformAnim");
			alreadyTriggered = true;
			questionPanel.SetActive(true);
			decoyButton.SetActive(true);
			Time.timeScale = 0;
		}
	}
}