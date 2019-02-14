using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfvalBakken : MonoBehaviour
{
    ObjectType objectype;
    [HideInInspector]
    public ObjectType Glasbak;
    [HideInInspector]
    public ObjectType GFTbak;
    [HideInInspector]
    public ObjectType Plasticbak;
    [HideInInspector]
    public ObjectType Restbak;

    public bool ItemCorrect;

    void Start()
    {
        Glasbak = ObjectType.Glas;
        GFTbak = ObjectType.Gft;
        Plasticbak = ObjectType.Plastic;
        Restbak = ObjectType.Rest;

    }

    
}
