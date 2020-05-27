using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
	public Rigidbody2D rb;
	public float speed;
	private Waypoints Wpoints;
	private int waypointIndex;
	public float enemyWaitTime;
	public bool canContinue;
	public bool teste;
	public Animator animator;
	private Vector2 direction;
	public Vector2 directionNew;
	public Vector2 directionNow;

	public Transform startPosition;
	public Transform[] wayRayArray;
	public float distance;


	// Start is called before the first frame update
	void Start()
    {
		Wpoints = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoints>();
		Physics2D.queriesStartInColliders = false;
    }

    // Update is called once per frame
    void Update()
    {
		EnemyPatrol();
		Animation();
		//StealthRaycast();

    }

	IEnumerator WaitToContinue()
	{
		yield return new WaitForSeconds(enemyWaitTime);
		canContinue = true;
	}

	public void EnemyPatrol()
	{
		directionNow = transform.position;
		transform.position = Vector2.MoveTowards(transform.position, Wpoints.waypoints[waypointIndex].position, speed * Time.deltaTime);
		directionNew = transform.position;
		direction = (directionNew - directionNow).normalized;
		if (Vector2.Distance(transform.position, Wpoints.waypoints[waypointIndex].position) < 0.1f)
		{
			StartCoroutine(WaitToContinue());

			if (canContinue)
			{
				waypointIndex++;
				teste = false;
			}
		}
		else
		{
			canContinue = false;
		}
		if (waypointIndex == 4)
		{
			waypointIndex = 0;
		}
			
	}

	void Animation()
	{
		animator.SetFloat("Horizontal", direction.x) ;
		animator.SetFloat("Vertical", direction.y);
		if(direction.x != 0 && direction.y != 0)
		{
			animator.SetBool("Moving", true);
		}
		else
		{
			animator.SetBool("Moving", false);
		}
	}

	void StealthRaycast()
	{
		Vector2 myPosition = wayRayArray[0].position;
		Vector2 myPosition2 = wayRayArray[1].transform.position + transform.position;
		RaycastHit2D hitInfo = Physics2D.Linecast(startPosition.position, myPosition) ;
		RaycastHit2D hitInfo2 = Physics2D.Raycast(transform.position, myPosition2, distance);


		if (hitInfo.collider.CompareTag("RustedDoor"))
		{
			Debug.Log("Acertou porta");
			Debug.DrawLine(startPosition.position, myPosition);
		}

		if (hitInfo2.collider.CompareTag("RustedDoor"))
		{
			Debug.Log("Acertou porta atrás");
		}

	}

}
