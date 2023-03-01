using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int Id { get; }
    public string Name { get; }
    public int Level { get; }
    public Rank Rank { get; }
    public Element? Element { get; }

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

        Card Card = AllCards.test;
        Debug.Log("Id "+ Card.Id);
        Debug.Log("Name "+ Card.Name);
        Debug.Log("Level: " + Card.Level);
        Debug.Log("Rank: " + Card.Rank.Top + Card.Rank.Right + Card.Rank.Bottom + Card.Rank.Left);
        Debug.Log("Element: " + Card.Element);
    }
}