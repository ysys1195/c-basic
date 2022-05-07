using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Animal
{
    public int age = 2;
    public string kind = "犬";

    public void Bite()
    {
        Debug.Log($"{age}歳の{kind}が噛み付く");
    }
}

public class ClassScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal dog = new Animal();

        Debug.Log(dog.kind);
        dog.age = 5;
        dog.Bite();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
