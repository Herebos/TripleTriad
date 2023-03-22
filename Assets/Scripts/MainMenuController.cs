using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    public void ClickOnCollectionMain()
    {
        Debug.Log("clicked Collection Main");
        SceneManager.LoadSceneAsync(3, LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync(0);
    }

    public void ClickOnShopMain()
    {
        Debug.Log("clicked Shop Main");
        SceneManager.LoadSceneAsync(2, LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync(0);
    }

    //Play menu
    public void ClickOnPlay()
    {
        Debug.Log("clicked Play");
        SceneManager.LoadSceneAsync(1, LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync(0);
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
