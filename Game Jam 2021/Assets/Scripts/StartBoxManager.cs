using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartBoxManager : MonoBehaviour
{
    private GameObject startBox;

    private void Start()
    {
        startBox = GameObject.FindGameObjectWithTag("StartBox");
    }
    public void ToggleBox()
    {
        startBox.SetActive(false);
    }
}
