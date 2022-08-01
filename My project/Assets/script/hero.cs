using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{
    string name = "Abdulrahman";
    string superpower = "fire";
    float height = 175f;
    int age = 17;
    string vilianname = "ucf";
    string viliansuperpower = "being him super strong";
    float vilianheigh = 176f;
    int vilianage = 18; 

    // Start is called before the first frame update
    void Start()
    {
        print("Hello i am the hero and name is " + name + " and my age is " + age + ", I konw i might be young but i am here to help you, my Height " + height + " and my superpower is the " + superpower);
        print(" vilian name " + vilianname + " age " + vilianage + " the height " + vilianheigh + " vilian superpaower " + viliansuperpower);
        int agedifference = vilianage - age;
        print(" age difference is " + agedifference);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
