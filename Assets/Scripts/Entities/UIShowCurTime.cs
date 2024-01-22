using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIShowCurTime : MonoBehaviour
{
    public TextMeshProUGUI curTimeText;

    // Update is called once per frame
    void Update()
    {
        curTimeText.text = DateTime.Now.ToString("HH:mm:ss");
    }
}
