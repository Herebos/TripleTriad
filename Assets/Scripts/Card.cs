using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

public class Card : MonoBehaviour
{
    //Behaviour
    public bool hasBeenPlayed;

    //DragAndDrop
    public bool canMove;
    public bool dragging;
    public bool isOverCardHolder;
    Collider2D CardCollider;
    public GameObject CardHolder;
    public Vector2 origin;
    public bool Available;

    //Sprite
    public Transform cardBG;
    public Transform cardFront;
    public Sprite[] spriteArray;
    private Sprite currentSprite;

    //Coroutine
    //Front
    public GameObject frontCard;
    public GameObject frontCardBG;
    public GameObject canvas;
    //Back
    public GameObject backCard;
    public Sprite backSprite;
    public float uncoverTime = 12.0f;

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
        //Get Camera to Canva
        Camera MyCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        GetComponentInChildren<Canvas>().worldCamera = MyCamera;
        //GetComponent<Canvas>().worldCamera = MyCamera;

        Id = Random.Range(0, 109);
        hasBeenPlayed = false;

        //Sprite
        //Sprite principal
        int i = Id + 1;
        string idString;
        idString = i.ToString();
        Sprite image = Resources.Load<Sprite>("cards/" + idString);
        cardFront.GetComponent<SpriteRenderer>().sprite = image;

        //Sprite background
        currentSprite = spriteArray[0];
        cardBG.GetComponent<SpriteRenderer>().sprite = currentSprite;

        //Front Sprite Pos
        frontCard.GetComponent<SpriteRenderer>().sortingOrder = -1;
        frontCardBG.GetComponent<SpriteRenderer>().sortingOrder = 0;
        canvas.GetComponent<Canvas>().sortingOrder = -1;

        //Back Sprite Pos
        backCard.GetComponent<SpriteRenderer>().sortingOrder = 1;
        
        //Dynamic variables
        var cards = AllCards.List.ToList();
        //Name
        Name = cards.ElementAtOrDefault(Id).Name;
        //Rank
        TopText.text = cards.ElementAtOrDefault(Id).Rank.Top.ToString();
        RightText.text = cards.ElementAtOrDefault(Id).Rank.Right.ToString();
        BottomText.text = cards.ElementAtOrDefault(Id).Rank.Bottom.ToString();
        LeftText.text = cards.ElementAtOrDefault(Id).Rank.Left.ToString();
        if(TopText.text == "10")
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

        //DragAndDrop
        isOverCardHolder = false;
        CardCollider = GetComponent<Collider2D>();
        canMove = false;
        dragging = false;
        origin = gameObject.transform.position;
        //Debug.Log(origin);

        /*//test
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
        */
    }

    void Update()
    {
        //Test change Owner
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeSprite();
            cardBG.GetComponent<SpriteRenderer>().sprite = currentSprite;
        }

        //DragAnd(Drop -> CardController)
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0) && !hasBeenPlayed)
        {
            if(CardCollider == Physics2D.OverlapPoint(mousePos))
            {
                canMove = true;
            } else
            {
                canMove = false;
            } if(canMove)
            {
                dragging = true;
            }
        }
        if(dragging)
        {
            transform.position = mousePos;
        } 
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOverCardHolder = true;
        CardHolder = collision.gameObject;
        Available = collision.gameObject.GetComponent<CardHolder>().Available;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isOverCardHolder = true;
        CardHolder = collision.gameObject;
        Available = collision.gameObject.GetComponent<CardHolder>().Available;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverCardHolder = false;
        CardHolder = null;
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

    public IEnumerator UncoverCard(Transform card, bool uncover)
    {

        float minAngle = uncover ? 180 : 0;
        float maxAngle = uncover ? 0 : 180;

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
                canvas.GetComponent<Canvas>().sortingOrder *= -1;
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