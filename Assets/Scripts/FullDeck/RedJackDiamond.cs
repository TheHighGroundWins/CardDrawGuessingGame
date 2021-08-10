using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedJackDiamond : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.DIAMOND;
         numberType = NumberEnums.NONE;
         faceType = FaceEnums.JACK;
         aceSelected = false;
         colorType = ColorEnums.RED;
    }

}
