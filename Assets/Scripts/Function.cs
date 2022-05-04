using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Hello("佐藤"));

        Debug.Log(Hello("佐藤", "田中", "吉田"));

        Hello();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string Hello(string name)
    {
        return $"こんにちは、{name}さん";
    }

    string Hello(string name1, string name2, string name3)
    {
        return $"こんにちは、{name1}さん、{name2}さん、{name3}さん。";
    }

    void Hello()
    {
        Debug.Log("こんにちは");
    }
}
