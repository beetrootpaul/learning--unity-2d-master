using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iteration : MonoBehaviour
{
    public string[] elements = {"first", "second"};

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < elements.Length; ++i)
        {
            Debug.Log("Element " + i + " is = " + elements[i]);
        }
        foreach (string text in elements)
        {
            Debug.Log("Element is = " + text);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}