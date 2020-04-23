using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
	public Door Opendoor; 
    // Start is called before the first frame update
    void Start()
    {
		Opendoor = GameObject.FindGameObjectWithTag("Door").GetComponent<Door>();
	}

	public void OpenDoor()
	{
		Opendoor.OpenDoor();
	}
}
