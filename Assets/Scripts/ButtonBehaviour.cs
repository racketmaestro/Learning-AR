using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

// This script will cause myObject to appear and do whatever when virtual button is activated
public class ButtonBehaviour : MonoBehaviour
{
    public GameObject myObject;
    VirtualButtonBehaviour vbutton;
    // Start is called before the first frame update
    void Start()
    {
        myObject.SetActive(false);
        // myObject is deactivated at start (hidden) 
        vbutton = GetComponentInChildren<VirtualButtonBehaviour>();
        vbutton.RegisterOnButtonPressed(onButtonPressed);
        vbutton.RegisterOnButtonReleased(onButtonReleased);
    }
    void onButtonPressed(VirtualButtonBehaviour vb)
    {
        myObject.SetActive(true);
    }
    void onButtonReleased(VirtualButtonBehaviour vb)
    {
        myObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
