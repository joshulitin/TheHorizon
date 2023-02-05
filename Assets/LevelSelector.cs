using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{

	
	public void Stage1Level1()
	{
		SceneManager.LoadScene(2);
	}
	public void Stage1Level2()
	{
		SceneManager.LoadScene(3);
	}
	public void Stage1Level3()
	{
		SceneManager.LoadScene(4);
	}
}
