using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHolder : MonoBehaviour
{
    public bool Available;

    private void Start()
    {
        Available = true;
    }


	public void PlaceCard()
	{
		if (Available)
		{
			//Card.transform.position = CardHolder.transform.position;
			Available = !Available;
		} else
        {
			Available = !Available;
		}


	}


}
