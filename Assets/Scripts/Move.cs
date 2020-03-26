using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
	public Transform player;
	public float moveSpeed = 5f;
	public Joystick joystick;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		PlayerMove();
    }

	void PlayerMove()
	{
		if (joystick.Horizontal >= .2f)
		{
			player.transform.Translate(new Vector2(joystick.Horizontal * moveSpeed * Time.deltaTime, joystick.Vertical * moveSpeed * Time.deltaTime));
		}
		else if (joystick.Horizontal <= .2f)
		{
			player.transform.Translate(new Vector2(joystick.Horizontal * moveSpeed * Time.deltaTime, joystick.Vertical * moveSpeed * Time.deltaTime));
		}
	}
}	
