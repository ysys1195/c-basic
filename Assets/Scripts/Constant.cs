using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constant : MonoBehaviour
{
    const float COMSUMPUTION_TAX = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"2021年時点で100円の商品の消費税は{100 * COMSUMPUTION_TAX}円");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
