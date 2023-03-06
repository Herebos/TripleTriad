using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DeckHand : MonoBehaviour
{
    public List<GameObject> HandList;
    public GameObject Card;
    readonly List<GameObject> Cards = new();
    Vector3 handPos;
    int i = 1;
    GameObject canvas;


    private void Start()
    {
        foreach(var holder in HandList)
        {
            Debug.Log(holder.transform.position);
            handPos = holder.transform.position;
            GameObject newCard = Instantiate(Card, handPos, Quaternion.identity);
            newCard.AddComponent<SortingGroup>().sortingOrder = i;
            canvas = newCard.transform.GetChild(0).GetChild(1).gameObject;
            canvas.GetComponent<Canvas>().sortingOrder = i;
            i++;
            Cards.Add(newCard);
        }
    }



}
