using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackTwoClub : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.CLUB;
         numberType = NumberEnums.TWO;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.BLACK;
    }
}
