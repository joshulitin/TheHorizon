using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer2button410 : MonoBehaviour
{
	public GameObject button2;

	List<string> secondChoice = new List<string>() { "go", "pick", "A red car", "Interrogative", "Us" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TextControl4101.randomQuestion > -1)
		{
			button2.GetComponent<Text>().text = secondChoice[TextControl4101.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
        TextControl4101.selectedAnswer = gameObject.name;
        TextControl4101.choiceSelected = "y";
	}
}
