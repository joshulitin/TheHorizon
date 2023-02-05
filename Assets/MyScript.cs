using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{

	protected Joystick joystick;
	protected JoyButton joyButton;
    // Start is called before the first frame update
    void Start()
    {
		joystick = FindObjectOfType<Joystick>();
		joyButton = FindObjectOfType<JoyButton>();
    }

    // Update is called once per frame
    void Update()
    {
		var rigidbody = GetComponent<Rigidbody>();

		rigidbody.velocity = new Vector3(joystick.Horizontal * 5f,
										 rigidbody.velocity.y,
										 joystick.Vertical * 5f);
    }
	public void takeDamage(int damageAmount){
		//HeartHealthVisual.heartHealthSystemStatic.Damage(damageAmount);
	}

	public void Heal(int healAmount)
	{
		//HeartHealthVisual.heartHealthSystemStatic.Heal(healAmount);
		
	}
}
