using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameManager gm;
    public GameObject[] coins;
    public GameObject door;
    private int _coinCount;
    
    void Start()
    {
        _coinCount = coins.Length;
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
            Destroy(other.gameObject);
            _coinCount--;
            if (_coinCount <= 0)
            {
                Destroy(door);
            }
        }
    }
}
