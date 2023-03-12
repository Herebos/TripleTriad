//Thanks to GunnarKarlsson's Drag&Drop
using System;
using UnityEngine;
using UnityEngine.Rendering;
using System.Collections.Generic;
using System.Collections;

public class CardController : MonoBehaviour
{
	//Get Cards on boards for flip routine
	GameObject[] cardOnBoard;

	private void Start()
    {
		//Flip routine
		StartCoroutine(GetAndFlip(0.8f));
	}

    void Update()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
		//Test
		if (Input.GetMouseButtonDown(1))
		{
			StartCoroutine(hit.collider.gameObject.GetComponent<Card>().UncoverCard(hit.collider.gameObject.GetComponent<Card>().transform, true));
		}

		//(Drag)AndDrop
		if (Input.GetMouseButtonUp(0))
		{
			GameObject g = hit.collider.gameObject;

			//Place Card if CardHolder == true && Available == true
			if (Input.GetMouseButtonUp(0) && g.GetComponent<Card>().isOverCardHolder && g.GetComponent<Card>().Available)
			{
				g.GetComponent<Card>().transform.position = g.GetComponent<Card>().CardHolder.transform.position;
				g.GetComponent<Card>().transform.rotation = Quaternion.Euler(0, 0, 0);
				g.GetComponent<Card>().canMove = false;
				g.GetComponent<Card>().dragging = false;
				g.GetComponent<SortingGroup>().sortingOrder = g.GetComponent<Card>().OrderLayer;
				g.GetComponent<Card>().transform.GetChild(0).GetChild(1).gameObject.GetComponent<Canvas>().sortingOrder = g.GetComponent<Card>().childCanvasOrder;
				//g.GetComponent<Card>().hasBeenPlayed = true;
				g.GetComponent<Card>().CardHolder.GetComponent<CardHolder>().PlaceCard();
				g.GetComponent<Card>().Attack();
			}
			//Get to originPos if CardHolder == true && Available == false (On used CardHolder)
			if (Input.GetMouseButtonUp(0) && g.GetComponent<Card>().isOverCardHolder && !g.GetComponent<Card>().Available)
			{
				g.GetComponent<Card>().transform.position = g.GetComponent<Card>().origin;
				g.GetComponent<Card>().transform.rotation = Quaternion.Euler(0, 0, 0);
				g.GetComponent<Card>().canMove = false;
				g.GetComponent<Card>().dragging = false;
				g.GetComponent<SortingGroup>().sortingOrder = g.GetComponent<Card>().OrderLayer;
				g.GetComponent<Card>().transform.GetChild(0).GetChild(1).gameObject.GetComponent<Canvas>().sortingOrder = g.GetComponent<Card>().childCanvasOrder;
			}
			//Get to originPos if CardHolder == false && Available == false (on Board Mat)
			if (Input.GetMouseButtonUp(0) && !g.GetComponent<Card>().isOverCardHolder)
			{
				g.GetComponent<Card>().transform.position = g.GetComponent<Card>().origin;
				g.GetComponent<Card>().transform.rotation = Quaternion.Euler(0, 0, 0);
				g.GetComponent<Card>().canMove = false;
				g.GetComponent<Card>().dragging = false;
				g.GetComponent<SortingGroup>().sortingOrder = g.GetComponent<Card>().OrderLayer;
				g.GetComponent<Card>().transform.GetChild(0).GetChild(1).gameObject.GetComponent<Canvas>().sortingOrder = g.GetComponent<Card>().childCanvasOrder;
			}
		}

	}

	//Flip routine
	IEnumerator GetAndFlip(float delay)
	{
		yield return new WaitForSeconds(delay);
		//5 Cards on Boards
		for (var i = 0; i < 4; i++)
		{
			cardOnBoard = GameObject.FindGameObjectsWithTag("Card");
		}
		foreach (var n in cardOnBoard)
		{
			StartCoroutine(n.GetComponent<Card>().UncoverCard(n.transform, true));
			yield return new WaitForSeconds(0.3f);
		}
	}

}
