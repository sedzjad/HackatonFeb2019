using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    public float redfade = 1;
    public float bluefade = 1;
    public float greenfade = 1;
    public float opacity = 1;
    [SerializeField]private float decrease = 0.05f;
    Camera cam;
    void Start()
    {
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
    }

    void Update()
    {
        Color fade = new Color(redfade,greenfade, bluefade, opacity);


        //if (Input.GetKey(KeyCode.Mouse0))
//        {
//            GreenUp();
//        }


        if (Input.GetKey(KeyCode.Mouse1))
        {
        RedUp();
        }

        cam.backgroundColor = fade;
    }

    public void GreenUp()
    {
        if (redfade > 0)
            redfade -= decrease;
        if (bluefade > 0)
            bluefade -= decrease;
        if (greenfade < 1)
            greenfade += decrease;
    }

    public void RedUp()
    {
        if (greenfade > 0)
            greenfade -= decrease;
        if (bluefade > 0)
            bluefade -= decrease;
        if (redfade < 1)
            redfade += decrease;
    }
}
