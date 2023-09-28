using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour
{
    public TextMeshProUGUI guiTextLink;
    void Start()
    {
        guiTextLink.text = DataHolder.winner.Substring(0, 8);
    }
}
