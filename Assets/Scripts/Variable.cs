using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable : MonoBehaviour
{
    int variable = 30;

    // Start is called before the first frame update
    void Start()
    {
        variable = 60;
        Debug.Log(variable);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
