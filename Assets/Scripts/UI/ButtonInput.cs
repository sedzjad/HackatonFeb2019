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

    private int Score;

    public Text ScoreBox;

    public void Start()
    {
        objProp = GameObject.FindWithTag("Object").GetComponent<ObjectProperty>();
        CheckingItemType();

    }

    public void CheckingItemType()
    {
        switch (objProp.objType)
        {
            case ObjectType.Glas:
                Glass = true;
                GFT = false;
                Plastic = false;
                Rest = false;
                break;
            case ObjectType.Gft:
                GFT = true;
                Glass = false;
                Plastic = false;
                Rest = false;
                break;
            case ObjectType.Plastic:
                Plastic = true;
                GFT = false;
                Glass = false;
                Rest = false;
                break;
            case ObjectType.Rest:
                Rest = true;
                GFT = false;
                Plastic = false;
                Glass = false;
                break;
        }
    }

    public void GlassButton()
    {
        if (Glass == true)
        {
            Score++;
            Color.GreenUp();
            ScoreBox.text = "Your score is: " + Score;
        }
        else
        {
            Score--;
            Color.RedUp();
            ScoreBox.text = "Your score is: " + Score;
        }
    }
    public void GftButton()
    {
        if (GFT == true)
        {
            Score++;
            Color.GreenUp();
            ScoreBox.text = "Your score is: " + Score;
        }
        else
        {
            Score--;
            Color.RedUp();
            ScoreBox.text = "Your score is: " + Score;
        }
    }
    public void PlasticButton()
    {
        if (Plastic == true)
        {
            Score++;
            Color.GreenUp();
            ScoreBox.text = "Your score is: " + Score;
        }
        else
        {
            Score--;
            Color.RedUp();
            ScoreBox.text = "Your score is: " + Score;
        }
    }
    public void RestButton()
    {
        if (Rest == true)
        {
            Score++;
            Color.GreenUp();
            ScoreBox.text = "Your score is: " + Score;
        }
        else
        {
            Score--;
            Color.RedUp();
            ScoreBox.text = "Your score is: " + Score;
        }
    }
 
}
