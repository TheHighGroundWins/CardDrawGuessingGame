using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTwoDiamond : Card
{


    void Awake()
    {

         suiteType = SuiteEnums.DIAMOND;
         numberType = NumberEnums.TWO;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.RED;
    }
}
