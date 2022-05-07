using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Monster
{
    public string kind = "モンスター";

    public void bodyBlow()
    {
        Debug.Log("たいあたり");
    }
}

class Dragon : Monster
{
    public void fireBreach()
    {
        Debug.Log("火の息を吐く");
    }
}

class Slime : Monster
{
    public void recovery()
    {
        Debug.Log("回復する");
    }
}

public class InheritanceScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dragon dragon = new Dragon();
        Debug.Log(dragon.kind);
        dragon.bodyBlow();
        dragon.fireBreach();

        Slime slime = new Slime();
        slime.bodyBlow();
        slime.recovery();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
