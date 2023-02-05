using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer4button441 : MonoBehaviour
{
	public GameObject button4;

	List<string> fourthChoice = new List<string>() { "warming", "Maple Syrup", "Thermometer", "Erosion", "desert" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl441.randomQuestion > -1)
		{	
			button4.GetComponent<Text>().text = fourthChoice[textControl441.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
		textControl441.selectedAnswer = gameObject.name;
		textControl441.choiceSelected = "y";
	}
}
