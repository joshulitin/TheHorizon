using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer3button452 : MonoBehaviour
{
	public GameObject button3;

	List<string> thirdChoice = new List<string>() { "Constellation", "Fall", "Reuse", "reusing", "sugar" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl452.randomQuestion > -1)
		{
			button3.GetComponent<Text>().text = thirdChoice[textControl452.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
		textControl452.selectedAnswer = gameObject.name;
		textControl452.choiceSelected = "y";
	}
}
