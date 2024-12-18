using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLevelThree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Loads next level 
    private void OnTriggerEnter(Collider other)
    {

        SceneManager.LoadScene("Level 4");

    }
}
