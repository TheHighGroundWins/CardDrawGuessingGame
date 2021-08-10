using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackAceClub : Card
{
    void Awake()
    {
        suiteType = SuiteEnums.CLUB;
        numberType = NumberEnums.NONE;
        faceType = FaceEnums.NONE;
        aceSelected = true;
        colorType = ColorEnums.BLACK;
    }
}
