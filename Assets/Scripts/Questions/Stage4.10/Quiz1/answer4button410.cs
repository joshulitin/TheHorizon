using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer4button410 : MonoBehaviour
{
	public GameObject button4;

	List<string> fourthChoice = new List<string>() { "Kevin", "walk", "Do short books", "Exclamatory", "Me" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TextControl4101.randomQuestion > -1)
		{	
			button4.GetComponent<Text>().text = fourthChoice[TextControl4101.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
        TextControl4101.selectedAnswer = gameObject.name;
        TextControl4101.choiceSelected = "y";
	}
}
