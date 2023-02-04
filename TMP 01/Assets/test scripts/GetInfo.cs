using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInfo : MonoBehaviour
{
    string myName = "Beetroot";
    private int myAge = 98;
    float myH = 1.23f;
    bool isSuper = true;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My name is: " + myName);
    }

    // Update is called once per frame
    void Update()
    {
    }
}