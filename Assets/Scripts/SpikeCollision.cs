using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        

    }

    // collider so the player is killed on impact with a spike.
    private void OnTriggerEnter(Collider other)
    {

        Destroy(other.gameObject);

    }
}
