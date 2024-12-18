using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Button menuButton;
    public Button quitButton;
    public GameObject areWeActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
 
        // opens menu 
        if (Input.GetKeyUp(KeyCode.Escape))
        {

            if (areWeActive.activeSelf == true)
            {

                quitButton.gameObject.SetActive(false);
                menuButton.gameObject.SetActive(false);
                areWeActive.SetActive(false);

            }
            else if (areWeActive.activeSelf == false)
            {

                quitButton.gameObject.SetActive(true);
                menuButton.gameObject.SetActive(true);
                areWeActive.SetActive(true);

            }
            

        }

    }


    // brings player to menu on click
    public void menuButtonClick()
    {

        SceneManager.LoadScene("Menu");

    }

    // quits game on click
    public void quitButtonClick()
    {

        Application.Quit();

    }

}
