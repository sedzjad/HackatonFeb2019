using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInput : MonoBehaviour
{
     public ObjectProperty objProp;
    public ChangeColour Color;

    private bool Glass = false;
    private bool GFT = false;
    private bool Plastic = false;
    private bool Rest = false;

    public bool Correct = false;

    public int Score;

    public Text ScoreBox;

    public void Start()
    {
        Score = 0;
        objProp = GameObject.FindWithTag("Object").GetComponent<ObjectProperty>();
    }
    public void Update()
    {
        
    }

    public void CheckingItemType()
    {
        switch (objProp.objType)
        {
            case ObjectType.Glas:
                Glass = true;
                break;
            case ObjectType.Gft:
                GFT = true;
                break;
            case ObjectType.Plastic:
                Plastic = true;
                break;
            case ObjectType.Rest:
                Rest = true;
                break;
        }
    }

    public void ButtonClick()
    {
        CheckingItemType();
        if (Glass == true)
        {
            Color.GreenUp();
            ScoreBox.text = "Your score is: " + (Score++);
        }
        if (GFT == true)
        {
            Color.GreenUp();
            ScoreBox.text = "Your score is: " + (Score++);
        }
        if (Plastic == true)
        {
            Color.GreenUp();
            ScoreBox.text = "Your score is: " + (Score++);
        }
        if (Rest == true)
        {
            Color.GreenUp();
            ScoreBox.text = "Your score is: " + (Score++);
        }
        
    }

 
}
