using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
	//Front Card
	public GameObject cardFront;
	public GameObject cardFrontBG;
	//Back Card
	public GameObject cardBack;
	public Sprite backSprite;

	public float uncoverTime = 12.0f;

	
	void Start()
	{
		GameObject card = gameObject; // parent object

		// front (motive)
		cardFront.GetComponent<SpriteRenderer>().sortingOrder = -1;
		cardFrontBG.GetComponent<SpriteRenderer>().sortingOrder = 0;

		// back
		cardBack.GetComponent<SpriteRenderer>().sortingOrder = 1;

		//int cardWidth = (int)backSprite.rect.width;
		//int cardHeight = (int)backSprite.rect.height;

		//Debug.Log(cardWidth);
		//Debug.Log(cardHeight);

		//card.tag = "Card";
		card.transform.parent = transform;
		card.transform.position = transform.position;
		//card.AddComponent<BoxCollider2D>();
		//card.GetComponent<BoxCollider2D>().size = new Vector2(cardWidth, cardHeight);

		Debug.Log("Start done");
	}


	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
			// we hit a card
			if (hit.collider != null)
			{
				Debug.Log(hit.collider.gameObject.name);
				StartCoroutine(UncoverCard(hit.collider.gameObject.transform, true));
			}
		}
	}

	IEnumerator UncoverCard(Transform card, bool uncover)
	{

		float minAngle = uncover ? 0 : 180;
		float maxAngle = uncover ? 180 : 0;

		float t = 0;
		bool uncovered = false;

		while (t < 1f)
		{
			t += Time.deltaTime * uncoverTime; ;

			float angle = Mathf.LerpAngle(minAngle, maxAngle, t);
			card.eulerAngles = new Vector3(0, angle, 0);

			if (((angle >= 90 && angle < 180) || (angle >= 270 && angle < 360)) && !uncovered)
			{
				uncovered = true;
				for (int i = 0; i < card.childCount; i++)
				{
					// reverse sorting order to show the otherside of the card
					// otherwise you would still see the same sprite because they are sorted 
					// by order not distance (by default)
					Transform c = card.GetChild(i);
					c.GetComponent<SpriteRenderer>().sortingOrder *= -1;

					yield return null;
				}
			}

			yield return null;
		}

		yield return 0;
	}

}
