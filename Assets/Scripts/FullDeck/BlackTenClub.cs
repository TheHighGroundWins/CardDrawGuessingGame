using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackTenClub : Card
{

    void Awake()
    {
         suiteType = SuiteEnums.CLUB;
         numberType = NumberEnums.TEN;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.BLACK;
    }
}
