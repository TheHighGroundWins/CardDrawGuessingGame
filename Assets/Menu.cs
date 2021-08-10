using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public void OnMenuClick()
    {
        Transform parentTransform = GameObject.FindWithTag("MainCanvas").GetComponent<Transform>();
        Instantiate<GameObject>((GameObject)Resources.Load("Main Menu"),parentTransform);
    }
}
