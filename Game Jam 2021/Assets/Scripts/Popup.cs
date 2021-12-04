using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Popup : MonoBehaviour
{

    [SerializeField] Button PauseButton; 
    [SerializeField] Button Continue;
    [SerializeField] Button Exit;

    public void Init(Transform canvas, Action exit)
    {
        transform.SetParent(canvas);
        transform.localScale = Vector3.one;

        Continue.onClick.AddListener(() => {
            action();
        });

        Exit.onClick.AddListener(() => {
            GameObject.Destroy(this.gameObject);
        });
    }
}
