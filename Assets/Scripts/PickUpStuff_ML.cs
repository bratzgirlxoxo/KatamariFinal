using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// USAGE: put this script on the Ball that will be pushed around
// INTENT: this script controls the sticking of things to the ball
public class PickUpStuff_ML : MonoBehaviour
{

	public float ballSize;

	private Rigidbody rBody;

	private float checkCounter;

	private float checkFrequency;

	void Start()
	{
		rBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		// move the ball around.... THIS IS JUST FOR TESTING...
		float horizontalInput = Input.GetAxis("Horizontal"); // get horizontal key input
		float verticalInput = Input.GetAxis("Vertical"); // get vertical key input
		
		Vector3 inputVector = new Vector3(horizontalInput, 0f, verticalInput); // combine the inputs

		rBody.velocity = inputVector; // set the velocity




		/*
		checkCounter += Time.deltaTime;

		if (checkCounter >= checkFrequency)
		{
			checkCounter = 0;

			for (int i = 0; i < transform.childCount; i++)
			{
				transform.GetChild(i)	
			}
		}
		*/
	}

	/*
	void OnCollisionEnter(Collision coll)
	{
		GameObject otherObject = coll.gameObject; // the gameobject of the thing we collided with

		// check to see if the other object is collectible;
		if (otherObject.CompareTag("Item"))
		{
			// check the size here... later
			
			// collect the object!
			otherObject.transform.parent = transform; // set the objects parent to this transform
		}
	}
	
	void OnTriggerEnter(Collider coll)
	{
		GameObject otherObject = coll.gameObject; // the gameobject of the thing we collided with

		// check to see if the other object is collectible;
		if (otherObject.CompareTag("Item"))
		{
			// check the size here... later
			
			
			// collect the object!
			otherObject.transform.parent = transform; // set the objects parent to this transform
		}
	}
	*/
}
