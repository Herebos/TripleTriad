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
			Available = !Available;
		} else
        {
			Available = !Available;
		}


	}


}
