using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    string[] sports = { "テニス", "サッカー", "バレー" };
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(sports[1]);
        Debug.Log(sports.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
