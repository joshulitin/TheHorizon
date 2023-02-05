using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer4button452 : MonoBehaviour
{
	public GameObject button4;

	List<string> fourthChoice = new List<string>() { "Milky Way", "Winter", "Rethink", "reducing", "oxygen" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl452.randomQuestion > -1)
		{	
			button4.GetComponent<Text>().text = fourthChoice[textControl452.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
		textControl452.selectedAnswer = gameObject.name;
		textControl452.choiceSelected = "y";
	}
}
