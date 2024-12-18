using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class WinLevelFive : MonoBehaviour
{

    public Button menuButton;
    public TextMeshProUGUI endTextOne;
    public TextMeshProUGUI endTextTwo;
    public TextMeshProUGUI endTextThree;
    public RawImage endBack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Loads ending screen
    private void OnTriggerEnter(Collider other)
    {

        menuButton.gameObject.SetActive(true);
        endTextOne.gameObject.SetActive(true);
        endTextTwo.gameObject.SetActive(true);
        endTextThree.gameObject.SetActive(true);
        endBack.gameObject.SetActive(true);

    }
}
