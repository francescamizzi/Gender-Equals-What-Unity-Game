using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class YouWin : MonoBehaviour
{
    [SerializeField] Button Exit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init(Transform canvas, Action exit)
    {
        transform.SetParent(canvas);
        transform.localScale = Vector3.one;

        Exit.onClick.AddListener(() => {
            GameObject.Destroy(this.gameObject);
        });
    }
}
