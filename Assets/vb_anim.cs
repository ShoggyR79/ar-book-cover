using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using TMPro;

public class vb_anim : MonoBehaviour
{
    public GameObject vbBtnObj;
    public TextMeshPro text;
    public GameObject rightArrow;
    public GameObject leftArrow;

    public string[] info = new string[2];
    private int infoIndex = 0; // Keeps track of which info is currently displayed

    // Cooldown mechanism
    private bool isButtonPressed = false;
    private float buttonCooldown = 1f; // 1 second cooldown
    private float lastButtonPressTime;

    void Start()
    {
        vbBtnObj = GameObject.Find("nextbtn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        text = GameObject.Find("textback").GetComponent<TextMeshPro>();
        rightArrow = GameObject.Find("RightArrow");
        leftArrow = GameObject.Find("LeftArrow");

        info[0] = "Seuss. (2023). Dr. Seuss’s who loves you? Random House Books for Young Readers. \n12 pages";
        info[1] = "Personal review: This was a good homage book to my younger self. I think it is a wonderful book \n for those dealing with hard times. The front cover image is to show homage to one of the page in the book where there is an actual mirror to see the reader.";

        UpdateText();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Pressed");
        isButtonPressed = true;
    }

    void UpdateText()
    {
        text.text = info[infoIndex];
        
        // Manage arrow visibility based on the current infoIndex
        Debug.Log("right");
        rightArrow.SetActive(infoIndex == 0);
        Debug.Log("left");
        leftArrow.SetActive(infoIndex == 1);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Released");
         if (Time.time - lastButtonPressTime < buttonCooldown)
        {
            // If button pressed again before cooldown is over, do nothing
            return;
        }
        isButtonPressed = false;
        lastButtonPressTime = Time.time;

        // Switch info text
        infoIndex = (infoIndex + 1) % info.Length; // Toggle between 0 and 1
        UpdateText();
        
    }

    void Update()
    {
        // Example if you need to handle continuous press or other interactions
        if (isButtonPressed)
        {
            // Handle continuous press if necessary
        }
    }
}
