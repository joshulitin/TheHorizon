﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer1button452 : MonoBehaviour
{
	public GameObject button1;

	List<string> firstChoice = new List<string>() { "Stars", "Summer", "Recycle", "recycling", "sunlight" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl452.randomQuestion > -1)
		{
			button1.GetComponent<Text>().text = firstChoice[textControl452.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
		textControl452.selectedAnswer = gameObject.name;
		textControl452.choiceSelected = "y";
		//Debug.Log(gameObject.name);
	}
}
