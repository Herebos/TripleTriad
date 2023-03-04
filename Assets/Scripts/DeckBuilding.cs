using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class DeckBuilding : MonoBehaviour
{

    public GameObject Card;
    readonly List<GameObject> Cards = new();
    public TextMeshProUGUI ToolTip;

    private void Start()
    {
        for(var i = 0; i < 7; i++)
        {
            GameObject newCard =  Instantiate(Card, new Vector3(-12 + i * 4.0f, 3, 0), Quaternion.identity);
            Cards.Add(newCard);
        }
        for (var u = 0; u < 7; u++)
        {
            GameObject newCard = Instantiate(Card, new Vector3(-12 + u * 4.0f, (float)-0.7, 0), Quaternion.identity);
            Cards.Add(newCard);
        }
    }

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

        //Tooltip
        try
        {
            TextMeshProUGUI ToolTipGO = GameObject.Find("ToolTipText").GetComponent<TextMeshProUGUI>();
            if (hit.collider != null)
            {
                var name = hit.collider.GetComponent<Card>().Name;
                ToolTipGO.enabled = true;
                ToolTip.text = hit.collider.GetComponent<Card>().Name;
                ToolTip.transform.position = Input.mousePosition;
            }
            if(hit.collider == null)
            {
                ToolTipGO.enabled = false;
            }
        }
        catch (NullReferenceException)
        {
            //Debug.Log("No card");
        }

        //Flip all cards
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var item in Cards)
            {
                StartCoroutine(item.GetComponent<Card>().UncoverCard(item.GetComponent<Card>().transform, true));
                Debug.Log(item.GetComponent<Card>().Name);
            }
        }
    }



}
