using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    int direction;

    IEnumerator Coroutine()
    {
        while(true) 
        {
            direction = Random.Range(1, 5);                 // 1-up, 2-down, 3-left, 4-right
            Debug.Log("Direction: " + direction);

            yield return new WaitForSeconds(2f);

            Debug.Log("Moving (2sec)");

            yield return new WaitForSeconds(2f);

            Debug.Log("Idling (2sec)");

            yield return new WaitForSeconds(2f);
        }
    }


    void Start()
    {
        StartCoroutine("Coroutine");
    }

    void Update()
    {
        
    }
}
