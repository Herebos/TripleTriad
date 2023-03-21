using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public GameObject playMenu;
    public GameObject mainMenu;


    public void ClickOnPlayMain()
    {
        Debug.Log("clicked Play Main");
        playMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void ClickOnDeckBuildingMain()
    {
        Debug.Log("clicked DB Main");
    }

    public void ClickOnShopMain()
    {
        Debug.Log("clicked Shop Main");
    }

    public void ClickOnPlay()
    {
        Debug.Log("clicked Play");
    }

    public void ClickOnChooseDeck()
    {
        Debug.Log("clicked Choose Deck");
    }

    public void ClickOnDeckBuildingPlay()
    {
        Debug.Log("clicked Deck building Play");
    }

    public void ClickOnReturn()
    {
        Debug.Log("clicked Return");
        playMenu.SetActive(false);
        mainMenu.SetActive(true);
    }



}
