using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        foreach(int number in numbers)
        {
            Debug.Log(number);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
