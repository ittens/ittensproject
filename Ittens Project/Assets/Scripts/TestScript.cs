using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    private int number;

    void Start()
    {
        for (int i=0; i<100; i++) {
            number = Random.Range(1, 5);
            Debug.Log(number);
        }
    }

    void Update()
    {

    }
}
