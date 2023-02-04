using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInfo : MonoBehaviour
{
    public string myName = "Beetroot";
    public int myAge = 98;
    float myH = 1.23f;
    bool isSuper = true;

    public DataProviderScript dps;

    // Start is called before the first frame update
    void Start()
    {
        PersInfo(myAge);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void PersInfo(int n)
    {
        Debug.Log("My name is: " + myName + " x " + n);
        Debug.Log(dps.providedX);
        Debug.Log(dps.providedY());
    }
}