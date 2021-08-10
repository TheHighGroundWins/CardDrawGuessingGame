using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedAceDiamond : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.DIAMOND;
         numberType = NumberEnums.NONE;
         faceType = FaceEnums.NONE;
         aceSelected = true;
         colorType = ColorEnums.RED;
    }
}
