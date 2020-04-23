using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
	public SpriteRenderer doorSprite;
	public BoxCollider2D doorCollider;
	public bool canOpen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			canOpen = true;
		}
	}

	public void OpenDoor()
	{
		if(canOpen == true)
		{
			doorSprite.enabled = false;
			doorCollider.enabled = false;
		}

	}
}
