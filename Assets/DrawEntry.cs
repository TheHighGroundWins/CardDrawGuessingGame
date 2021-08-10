using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DrawEntry : MonoBehaviour
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

    public void Back()
    {
        Destroy(gameObject);
    }

    public void finalizeChoice()
    {

        TMP_InputField inputText = GetComponentInChildren<TMP_InputField>();

        if (int.TryParse(inputText.text, out drawNumber))
        {
            GameObject tableInstance = Instantiate<GameObject>(table);
            tableInstance.GetComponent<CardGenerator>().SetCard(suiteType,
            numberType, faceType, aceSelected, colorType, drawNumber);
            Destroy(gameObject);
        }
        else
        {
            inputText.text = "Numbers Only";
        }

        Destroy(GameObject.FindWithTag("MainCanvas"));
    }
}
