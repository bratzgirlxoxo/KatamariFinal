using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAlign_ML : MonoBehaviour
{

	void OnCollisionEnter(Collision coll)
	{
		Vector3 collPoint;
		GameObject other = coll.gameObject;
		
		if (other.CompareTag("Player"))
		{
			collPoint = coll.contacts[0].point;
			GameObject hitPoint = new GameObject("Contact Point");
			hitPoint.transform.position = collPoint;
			hitPoint.transform.parent = other.transform;
			transform.parent = hitPoint.transform;
			transform.position = transform.parent.position;
		}
	}
}
