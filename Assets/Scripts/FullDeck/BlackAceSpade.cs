using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackAceSpade : Card
{
    void Awake()
    {
         suiteType = SuiteEnums.SPADE;
         numberType = NumberEnums.NONE;
         faceType = FaceEnums.NONE;
         aceSelected = true;
         colorType = ColorEnums.BLACK;
    }

}
