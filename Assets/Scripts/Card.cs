using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class Card : MonoBehaviour
{
    public Transform cardBG;
    public Transform cardFront;
    public Sprite[] spriteArray;
    private Sprite currentSprite;

    public IEnumerable<Card> List;

    public int Id;
    public string Name { get; set; }
    public int Level { get; set; }
    public Rank Rank { get; set; }
    public Element? Element { get; set; }


    


    public Card(int id, string name, int level, Rank rank, Element? element = null)
    {
        Id = id;
        Name = name;
        Level = level;
        Rank = rank;
        Element = element;
    }

    private void Start()
    {
        //Sprite principale
        int i = Id + 1;
        string idString;
        idString = i.ToString();
        Sprite image = Resources.Load<Sprite>("cards/" + idString);
        cardFront.GetComponent<SpriteRenderer>().sprite = image;

        //Sprite background
        currentSprite = spriteArray[0];
        cardBG.GetComponent<SpriteRenderer>().sprite = currentSprite;

        //test
        var cards = AllCards.List.ToList();
        var a = cards.ElementAtOrDefault(Id).Id;
        var b = cards.ElementAtOrDefault(Id).Name;
        Debug.Log(a);
        Debug.Log(b);
        Debug.Log("Sprite to load " + idString);
        Debug.Log("Name "+ cards.ElementAtOrDefault(Id).Name);
        Debug.Log("Level: " + cards.ElementAtOrDefault(Id).Level);
        Debug.Log("Rank: " + cards.ElementAtOrDefault(Id).Rank.Top + cards.ElementAtOrDefault(Id).Rank.Right + cards.ElementAtOrDefault(Id).Rank.Bottom + cards.ElementAtOrDefault(Id).Rank.Left);
        Debug.Log("Element: " + cards.ElementAtOrDefault(Id).Element);
        

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeSprite();
            cardBG.GetComponent<SpriteRenderer>().sprite = currentSprite;
        }
    }

    void ChangeSprite()
    {
        if(currentSprite == spriteArray[0])
        {
            currentSprite = spriteArray[1];
        } else
        {
            currentSprite = spriteArray[0];
        }
    }

}