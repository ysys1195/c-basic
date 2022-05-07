using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Human
{
    public int age = 25;
}

public class AccessModifierScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Human jack = new Human();
        Debug.Log(jack.age);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
