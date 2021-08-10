using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTenDiamond : Card
{


    void Awake()
    {
         suiteType=SuiteEnums.DIAMOND;
         numberType=NumberEnums.TEN;
         faceType=FaceEnums.NONE;
         aceSelected = false;
        colorType = ColorEnums.RED;
    }
}
