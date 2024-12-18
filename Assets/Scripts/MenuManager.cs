using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{

    public Button levelOneButton;
    public Button levelTwoButton;
    public Button levelThreeButton;
    public Button levelFourButton;
    public Button levelFiveButton;
    public Button backButton;
    public Button playButton;
    public Button quitButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Makes levels visable on click
    public void playButtonClick()
    {

        levelOneButton.gameObject.SetActive(true);
        levelTwoButton.gameObject.SetActive(true);
        levelThreeButton.gameObject.SetActive(true);
        levelFourButton.gameObject.SetActive(true);
        levelFiveButton.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);
        playButton.gameObject.SetActive(false);
        quitButton.gameObject.SetActive(false);

    }

    // Makes levels dissapear on click
    public void backButtonClick()
    {

        levelOneButton.gameObject.SetActive(false);
        levelTwoButton.gameObject.SetActive(false);
        levelThreeButton.gameObject.SetActive(false);
        levelFourButton.gameObject.SetActive(false);
        levelFiveButton.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);
        playButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);

    }

    // quits game on click
    public void quitButtonClick()
    {

       Application.Quit();

    }

    // brings player to level 1 on click
    public void levelOneButtonClick()
    {

        SceneManager.LoadScene("Level 1");

    }

    // brings player to level 2 on click
    public void levelTwoButtonClick()
    {

        SceneManager.LoadScene("Level 2");

    }

    // brings player to level 3 on click
    public void levelThreeButtonClick()
    {

        SceneManager.LoadScene("Level 3");

    }

    // brings player to level 4 on click
    public void levelFourButtonClick()
    {

        SceneManager.LoadScene("Level 4");

    }

    // brings player to level 5 on click
    public void levelFiveButtonClick()
    {

        SceneManager.LoadScene("Level 5");

    }
}
