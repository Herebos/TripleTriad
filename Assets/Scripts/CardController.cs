//Thanks to GunnarKarlsson
using System;
using UnityEngine;

public class CardController : MonoBehaviour
{
	public CardHolder chBool;


	// Update is called once per frame
	void Update()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

		//Flip Card
		try
		{
			if (Input.GetMouseButtonDown(0) && hit.collider.CompareTag("Card")) //Change when drag & drop is up
			{
				Debug.Log(hit.collider.name);
				StartCoroutine(hit.collider.GetComponent<Card>().UncoverCard(hit.collider.gameObject.transform, true));
			}
		} catch(NullReferenceException)
        {
			//Debug.Log("No card");
        }

		//Trigger CardHolder bool
		try
		{
			if (Input.GetMouseButtonUp(1) && hit.collider.CompareTag("CardHolder"))
			{
				Debug.Log(hit.collider.name);
				hit.collider.GetComponent<CardHolder>().PlaceCard();
			}
		} catch (NullReferenceException)
		{
			//Debug.Log("No cardHolder");
		}
	}
	

}
