using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameManager gm;
    public GameObject[] coins;
    public GameObject door;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (coins.Length == 0)
        {
            Destroy(door);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "winPlane")
        {
            gm.GameWin();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Debug.Log("amongus");
            Destroy(other.gameObject);
        }
    }
}
