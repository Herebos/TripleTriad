using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;

public class Card : MonoBehaviour
{
    //Test

    //Behaviour
    public bool hasBeenPlayed;
    float targetBlue;
    float targetRed;
    
    //DragAndDrop
    public bool canMove;
    public bool dragging;
    public bool isOverCardHolder;
    Collider2D CardCollider;
    public GameObject CardHolder;
    public Vector2 origin;
    public bool Available;
    public int OrderLayer;
    public GameObject canvas;
    public int childCanvasOrder;

    //Sprite
    public Transform cardBG;
    public Transform cardFront;
    public Sprite[] spriteArray;
    private Sprite currentSprite;

    //Coroutine
    //Front
    public GameObject frontCard;
    public GameObject frontCardBG;
    bool canvaEnabled;
    //Back
    public GameObject backCard;
    public Sprite backSprite;
    public float uncoverTime = 12.0f;

    //Attack
    [SerializeField] private Side[] sides = new Side[4];
    [field: SerializeField] public Team Team { get; set; }

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
    public Card(int id, string name, int level, Rank rank, int price, Element? element = null)
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
        //Test
        

        //Get Camera to Canva
        Camera MyCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        GetComponentInChildren<Canvas>().worldCamera = MyCamera;

        //Behaviour
        Id = Random.Range(0, 109);
        hasBeenPlayed = false;
        UpdateTeam(Team);
        if(Team == Team.BLUE)
        {
            //cardBG.GetComponent<SpriteRenderer>().sprite = currentSprite;
            cardBG.GetComponent<SpriteRenderer>().sprite = spriteArray[0];
        }
        if (Team == Team.RED)
        {
            //cardBG.GetComponent<SpriteRenderer>().sprite = currentSprite;
            cardBG.GetComponent<SpriteRenderer>().sprite = spriteArray[1];
        }

        //Sprite
        //Sprite principal
        int i = Id + 1;
        string idString;
        idString = i.ToString();
        Sprite image = Resources.Load<Sprite>("cards/" + idString);
        cardFront.GetComponent<SpriteRenderer>().sprite = image;

        //Sprite background
        //currentSprite = spriteArray[0];
        //cardBG.GetComponent<SpriteRenderer>().sprite = currentSprite;

        //Front Sprite Pos
        frontCard.GetComponent<SpriteRenderer>().sortingOrder = -1;
        frontCardBG.GetComponent<SpriteRenderer>().sortingOrder = 0;
        canvas.GetComponent<Canvas>().enabled = false;
        canvaEnabled = false;

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
        targetBlue = origin.x - 1.0f;
        targetRed = origin.x + 1.0f;
        OrderLayer = gameObject.GetComponent<SortingGroup>().sortingOrder;
        childCanvasOrder = gameObject.transform.GetChild(0).GetChild(1).GetComponent<Canvas>().sortingOrder;

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
            ChangeBGSprite();
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
            //Drag effect
            Vector3 mousePos2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Vector2 direction = mousePos2 - transform.position;

            if (direction.sqrMagnitude > 0)
            {
                Quaternion targetRotation = Quaternion.LookRotation(direction);

                float degreesPerSecond = 50.0f * Time.deltaTime;
                transform.SetPositionAndRotation(mousePos, Quaternion.RotateTowards(transform.rotation, targetRotation, degreesPerSecond));
            } else
            {
                transform.SetPositionAndRotation(mousePos, Quaternion.Euler(0, 0, 0));
            }
            //Sorting Order
            gameObject.GetComponent<SortingGroup>().sortingOrder = 10;
            gameObject.transform.GetChild(0).GetChild(1).gameObject.GetComponent<Canvas>().sortingOrder = 10;
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

    private void OnMouseEnter()
    {
        if (Team == Team.BLUE && !isOverCardHolder)
        {
            transform.position = new Vector2(targetBlue, transform.position.y);
        }
        if (Team == Team.RED && !isOverCardHolder)
        {
            transform.position = new Vector2(targetRed, transform.position.y);
        }
    }

    private void OnMouseExit()
    {
        if (!isOverCardHolder)
        {
           transform.position = origin;
        }
    }

    void ChangeBGSprite()
    {
        if(Team == Team.RED)
        {
            //currentSprite = spriteArray[1];
            Debug.Log("ChangeBG inside from blue to red");
            cardBG.GetComponent<SpriteRenderer>().sprite = spriteArray[1];
        } if (Team == Team.BLUE)
        {
            //currentSprite = spriteArray[0];
            Debug.Log("ChangeBG inside from red to blue");
            cardBG.GetComponent<SpriteRenderer>().sprite = spriteArray[0];
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
                if (!canvaEnabled)
                {
                    canvaEnabled = !canvaEnabled;
                    canvas.GetComponent<Canvas>().enabled = canvaEnabled;
                } else
                {
                    canvaEnabled = !canvaEnabled;
                    canvas.GetComponent<Canvas>().enabled = canvaEnabled;
                }
                for (int i = 0; i < card.childCount; i++)
                {
                    // reverse sorting order to show the otherside of the card
                    // otherwise you would still see the same sprite because they are sorted 
                    // by order not distance (by default)
                    Transform c = card.GetChild(i);
                    if (c.GetComponent<SpriteRenderer>() == true)
                    {
                        c.GetComponent<SpriteRenderer>().sortingOrder *= -1;
                    }

                    yield return null;
                }
            }

            yield return null;
        }

        yield return 0;
    }


    public void UpdateTeam(Team team)
    {
        Team = team;
        Debug.Log("Update Team inside");
        StartCoroutine(UncoverCard(gameObject.transform, true));
        ChangeBGSprite();
        StartCoroutine(UncoverCard(gameObject.transform, true));

        //for (int i = 0; i < sides.Length; i++)
        //{
        //    //sides[i].Background.color = GenericAttribute.GetAttribute<CustomColorAttribute>(team).HexadecimalToRGBColor();
        //}
    }

    //Attack
    public void Attack()
    {
        int powerIndex = 0;
        List<Card> capturedCards = new List<Card>();
        for(int i =0; i < sides.Length; i++)
        {
            Card enemy = sides[i].GetTarget();
            Debug.Log(i);
            powerIndex = i + 2;

            if(powerIndex >= sides.Length)
            {
                powerIndex = powerIndex % 2;
            }
            if (enemy != null )//&& enemy.hasBeenPlayed)
            {
                //Normal capture
                if (i == 0)
                {
                    string PlayedTopText = TopText.text;
                    PlayedTopText = PlayedTopText.Replace("A", "10");
                    int PlayedTopInt;
                    int.TryParse(PlayedTopText, out PlayedTopInt);
                    string EnemyBottomText = enemy.BottomText.text;
                    EnemyBottomText = EnemyBottomText.Replace("A", "10");
                    int EnemyBottomInt;
                    int.TryParse(EnemyBottomText, out EnemyBottomInt);
                    if (enemy.Team != Team && PlayedTopInt > EnemyBottomInt) //&& get Side of enemy Card < Card.Side)
                    {
                        Debug.Log("PlayedTop " + PlayedTopText);
                        Debug.Log("Ennemy Bottom " + EnemyBottomText);
                        capturedCards.Add(enemy);
                    }
                }
                if (i == 1)
                {
                    string PlayedRightText = RightText.text;
                    PlayedRightText = PlayedRightText.Replace("A", "10");
                    int PlayedRightInt;
                    int.TryParse(PlayedRightText, out PlayedRightInt);
                    string EnemyLeftText = enemy.LeftText.text;
                    EnemyLeftText = EnemyLeftText.Replace("A", "10");
                    int EnemyLeftInt;
                    int.TryParse(EnemyLeftText, out EnemyLeftInt);
                    //Normal capture
                    if (enemy.Team != Team && PlayedRightInt > EnemyLeftInt) //&& get Side of enemy Card < Card.Side)
                    {
                        Debug.Log("PlayedRight " + PlayedRightText);
                        Debug.Log("EnemyLeft " + EnemyLeftText);
                        capturedCards.Add(enemy);
                    }
                }
                if (i == 2)
                {
                    string PlayedBottomText = BottomText.text;
                    PlayedBottomText = PlayedBottomText.Replace("A", "10");
                    int PlayedBottomInt;
                    int.TryParse(PlayedBottomText, out PlayedBottomInt);
                    string EnemyTopText = enemy.TopText.text;
                    EnemyTopText = EnemyTopText.Replace("A", "10");
                    int EnemyTopInt;
                    int.TryParse(EnemyTopText, out EnemyTopInt);
                    //Normal capture
                    if (enemy.Team != Team && PlayedBottomInt > EnemyTopInt) //&& get Side of enemy Card < Card.Side)
                    {
                        Debug.Log("PlayedBottom " + PlayedBottomText);
                        Debug.Log("EnemyTop " + EnemyTopText);
                        capturedCards.Add(enemy);
                    }
                }
                if (i == 3)
                {
                    string PlayedLeftText = LeftText.text;
                    PlayedLeftText = PlayedLeftText.Replace("A", "10");
                    int PlayedLeftInt;
                    int.TryParse(PlayedLeftText, out PlayedLeftInt);
                    string EnemyRightText = enemy.RightText.text;
                    EnemyRightText = EnemyRightText.Replace("A", "10");
                    int EnemyRightInt;
                    int.TryParse(EnemyRightText, out EnemyRightInt);
                    //Normal capture
                    if (enemy.Team != Team && PlayedLeftInt > EnemyRightInt) //&& get Side of enemy Card < Card.Side)
                    {
                        Debug.Log("PlayedLeft " + PlayedLeftText);
                        Debug.Log("EnemyRight " + EnemyRightText);
                        capturedCards.Add(enemy);
                    }
                }
            }
        }

        //Switch Team
        capturedCards.ForEach(card =>
        {
            card.UpdateTeam(Team);
            //Debug.Log("Update Team");

            //if (activeRule)
            //{
            //   card.Attack(true);
            //}
        });

    }

}

public enum Team
{
    BLUE = 0,
    RED = 1
}