using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class answer3button451 : MonoBehaviour
{
	public GameObject button3;

	List<string> thirdChoice = new List<string>() { "stem", "forest", "touch", "corn", "banana" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textControl451.randomQuestion > -1)
		{
			button3.GetComponent<Text>().text = thirdChoice[textControl451.randomQuestion];
		}
    }

	public void TaskOnClick()
	{
		textControl451.selectedAnswer = gameObject.name;
		textControl451.choiceSelected = "y";
	}
}
