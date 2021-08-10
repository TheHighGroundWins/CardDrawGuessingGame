using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedNineDiamond : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.DIAMOND;
         numberType = NumberEnums.NINE;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.RED;
    }
}
