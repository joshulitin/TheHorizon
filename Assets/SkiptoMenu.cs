using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SkiptoMenu : MonoBehaviour
{
	public void toSkip()
	{
		SceneManager.LoadScene(1);
	}
}
