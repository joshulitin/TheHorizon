using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer2button452 : MonoBehaviour
{
	public GameObject button2;

	List<string> secondChoice = new List<string>() { "Kuiper's Belt", "Spring", "Reduce", "reducing", "soil" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl452.randomQuestion > -1)
		{
			button2.GetComponent<Text>().text = secondChoice[textControl452.randomQuestion];
		}
    }

	public void TaskOnClick()
	{	
		textControl452.selectedAnswer = gameObject.name;
		textControl452.choiceSelected = "y";
	}
}
