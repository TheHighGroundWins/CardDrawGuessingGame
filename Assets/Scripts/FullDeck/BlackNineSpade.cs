using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackNineSpade : Card
{
    void Awake()
    {
         suiteType = SuiteEnums.SPADE;
         numberType = NumberEnums.NINE;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.BLACK;
    }
}
