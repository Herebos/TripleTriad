//Thanks to GunnarKarlsson
using UnityEngine;

public class CardController : MonoBehaviour
{
	public Transform[] cardSlots;
	public bool[] availableCardSlots;


	// Update is called once per frame
	void Update()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

		if (Input.GetMouseButtonDown(0) && hit.collider != null)
		{
			StartCoroutine(hit.collider.GetComponent<Card>().UncoverCard(hit.collider.gameObject.transform, true));
		}
	}

	public void PlaceCard()
    {
		for (int i = 0; i < availableCardSlots.Length; i++)
        {
			if(availableCardSlots[i] == true)
            {
				//card position = cardSlots[i].position;
				availableCardSlots[i] = false;
            }
        }
    }

	

}
