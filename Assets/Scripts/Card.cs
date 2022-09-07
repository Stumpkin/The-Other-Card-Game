using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    // Start is called before the first frame update
    public int atmoicNumber;
    public string elementName;
    public int type;

    void setName(string n)
    {
        name = n;
    }
    
    void setNumber(int n)
    {
        atmoicNumber = n;
    }

    void setType(int t)
    {
        type = t;
    }

    string getName()
    {
        return name;
    }

    int getNumber()
    {
        return atmoicNumber;
    }

    int getType()
    {
        return type;
    }
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
