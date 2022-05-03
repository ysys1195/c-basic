using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmbedVariable : MonoBehaviour
{
    string name = "太郎";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"こんにちは、{name}さん");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
