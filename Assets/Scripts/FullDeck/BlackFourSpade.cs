using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackFourSpade : Card
{

    void Awake()
    {
         suiteType = SuiteEnums.SPADE;
         numberType = NumberEnums.FOUR;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.BLACK;
    }
}
