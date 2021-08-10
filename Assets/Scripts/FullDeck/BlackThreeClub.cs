using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackThreeClub : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.CLUB;
         numberType = NumberEnums.THREE;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.BLACK;
    }
}
