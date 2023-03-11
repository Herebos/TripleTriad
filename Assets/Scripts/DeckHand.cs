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
        if (gameObject.name == "DeckHandBlue")
        {
            foreach (var holder in HandList)
            {
                handPos = holder.transform.position;
                GameObject newCard = Instantiate(Card, handPos, Quaternion.identity);
                newCard.AddComponent<SortingGroup>().sortingOrder = i;
                newCard.GetComponent<Card>().Team = Team.BLUE;
                canvas = newCard.transform.GetChild(0).GetChild(1).gameObject;
                canvas.GetComponent<Canvas>().sortingOrder = i;
                i++;
                Cards.Add(newCard);
            }
        }
        if (gameObject.name == "DeckHandRed")
        {
            foreach (var holder in HandList)
            {
                handPos = holder.transform.position;
                GameObject newCard = Instantiate(Card, handPos, Quaternion.identity);
                newCard.AddComponent<SortingGroup>().sortingOrder = i;
                newCard.GetComponent<Card>().Team = Team.RED;
                canvas = newCard.transform.GetChild(0).GetChild(1).gameObject;
                canvas.GetComponent<Canvas>().sortingOrder = i;
                i++;
                Cards.Add(newCard);
            }
        }
    }



}
