//Thanks to GunnarKarlsson
using System;
using UnityEngine;

public class CardController : MonoBehaviour
{
	void Update()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
		
		//Flip Card
		try
		{
			if (Input.GetMouseButtonDown(1) && hit.collider.CompareTag("Card")) //Change when drag & drop is up
			{
				Debug.Log(hit.collider.name);
				StartCoroutine(hit.collider.GetComponent<Card>().UncoverCard(hit.collider.gameObject.transform, true));
			}
		} catch(NullReferenceException)
        {
			//Debug.Log("No card");
        }


		//(Drag)AndDrop
		if (Input.GetMouseButtonUp(0))
		{
			GameObject g = hit.collider.gameObject;
			Debug.Log(g);

			//Place Card if CardHolder == true && Available == true
			if (Input.GetMouseButtonUp(0) && g.GetComponent<Card>().isOverCardHolder && g.GetComponent<Card>().Available)
			{
				g.GetComponent<Card>().transform.position = g.GetComponent<Card>().CardHolder.transform.position;
				g.GetComponent<Card>().canMove = false;
				g.GetComponent<Card>().dragging = false;
				//hasBeenPlayed = true; //implement soonTM
				g.GetComponent<Card>().CardHolder.GetComponent<CardHolder>().PlaceCard();
			}
			//Get to originPos if CardHolder == true && Available == false (On used CardHolder)
			if (Input.GetMouseButtonUp(0) && g.GetComponent<Card>().isOverCardHolder && !g.GetComponent<Card>().Available)
			{
				g.GetComponent<Card>().transform.position = g.GetComponent<Card>().origin;
				g.GetComponent<Card>().canMove = false;
				g.GetComponent<Card>().dragging = false;
			}
			//Get to originPos if CardHolder == false && Available == false (on Board Mat)
			if (Input.GetMouseButtonUp(0) && !g.GetComponent<Card>().isOverCardHolder)
			{
				g.GetComponent<Card>().transform.position = g.GetComponent<Card>().origin;
				g.GetComponent<Card>().canMove = false;
				g.GetComponent<Card>().dragging = false;
			}
		}

	}


}