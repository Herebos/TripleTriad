using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopController : MonoBehaviour
{


    public void ClickOnReturn()
    {
        Debug.Log("clicked Return");
        SceneManager.LoadSceneAsync(0, LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync(2);
    }

}
