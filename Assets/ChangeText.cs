using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("buttonName").GetComponentInChildren<Text>().text = "v";

    }
}
