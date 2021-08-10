using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackNineClub : Card
{


    void Awake()
    {
         suiteType = SuiteEnums.CLUB;
         numberType = NumberEnums.NINE;
         faceType = FaceEnums.NONE;
         aceSelected = false;
         colorType = ColorEnums.BLACK;
    }
}
