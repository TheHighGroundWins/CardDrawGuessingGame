using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DrawEntry : MonoBehaviour
{

    GameObject AndOr;

     SuiteEnums suiteType;
     NumberEnums numberType;
     FaceEnums faceType;
     bool aceSelected;
     ColorEnums colorType;
     int drawNumber;

    void Start()
    {
        AndOr = (GameObject)Resources.Load("AndOr");
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

    public void Back()
    {
        Destroy(gameObject);
    }

    public void finalizeChoice()
    {

        TMP_InputField inputText = GetComponentInChildren<TMP_InputField>();

        if (int.TryParse(inputText.text, out drawNumber))
        {
            GameObject andOrInstance = Instantiate<GameObject>(AndOr,transform);
            andOrInstance.GetComponent<And>().SetCardInfo(suiteType,
            numberType, faceType, aceSelected, colorType, drawNumber);
            
            andOrInstance.GetComponent<Or>().SetCardInfo(suiteType,
            numberType, faceType, aceSelected, colorType, drawNumber);
        }
        else
        {
            inputText.text = "Numbers Only";
        }
    }
}
