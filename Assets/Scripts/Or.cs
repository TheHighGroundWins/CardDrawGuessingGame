using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Or : MonoBehaviour
{
    GameObject table;
     
     SuiteEnums suiteType;
     NumberEnums numberType;
     FaceEnums faceType;
     bool aceSelected;
     ColorEnums colorType;
     int drawNumber;
     
    void Start()
    {
        table = (GameObject)Resources.Load("Table");
    }

    public void SetCardInfo(SuiteEnums suiteType, NumberEnums numberType,
        FaceEnums faceType, bool aceSelected, ColorEnums colorType, int drawNumber)
    {
        this.suiteType = suiteType;
        this.numberType = numberType;
        this.faceType = faceType;
        this.aceSelected = aceSelected;
        this.colorType = colorType;
        this.drawNumber = drawNumber;
    }

    // Start is called before the first frame update
    public void StartCard()
    {
       GameObject tableInstance = Instantiate<GameObject>(table);
            tableInstance.GetComponent<CardGenerator>().SetCard(suiteType,
            numberType, faceType, aceSelected, colorType, drawNumber, false);
        Destroy(GameObject.FindWithTag("MainCanvas"));

    }
}
