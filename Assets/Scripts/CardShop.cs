using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;

public class CardShop : MonoBehaviour
{
    //Sprite
    public Transform cardBG;
    public Transform cardFront;
    public Sprite[] spriteArray;

    //Card constructor
    public IEnumerable<Card> List;
    public TextMeshProUGUI TopText;
    public TextMeshProUGUI RightText;
    public TextMeshProUGUI BottomText;
    public TextMeshProUGUI LeftText;

    public int Id;
    public string Name { get; set; }
    public int Level { get; set; }
    public Rank Rank { get; set; }
    public Element? Element { get; set; }
    public int Price;
    public CardShop(int id, string name, int level, Rank rank, int price, Element? element = null)
    {
        Id = id;
        Name = name;
        Level = level;
        Rank = rank;
        Price = price;
        Element = element;
    }


    private void Start()
    {
        //BG sprite (grey)
        cardBG.GetComponent<SpriteRenderer>().sprite = spriteArray[0];

        //Sprite principal
        int i = Id + 1;
        string idString;
        idString = i.ToString();
        Sprite image = Resources.Load<Sprite>("cards/" + idString);
        cardFront.GetComponent<SpriteRenderer>().sprite = image;

        //Dynamic variables
        var cards = AllCards.List.ToList();
        //Name
        Name = cards.ElementAtOrDefault(Id).Name;
        //Rank
        TopText.text = cards.ElementAtOrDefault(Id).Rank.Top.ToString();
        RightText.text = cards.ElementAtOrDefault(Id).Rank.Right.ToString();
        BottomText.text = cards.ElementAtOrDefault(Id).Rank.Bottom.ToString();
        LeftText.text = cards.ElementAtOrDefault(Id).Rank.Left.ToString();
        if (TopText.text == "10")
        {
            TopText.text = "A";
        }
        if (RightText.text == "10")
        {
            RightText.text = "A";
        }
        if (BottomText.text == "10")
        {
            BottomText.text = "A";
        }
        if (LeftText.text == "10")
        {
            LeftText.text = "A";
        }
    }

}
