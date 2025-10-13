using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonAcitve : MonoBehaviour
{
    public GameObject GameObject;
    private bool active = true;
    private Vector3 data;
    private Vector3 position;
    private Quaternion rotation;
    
     public void Clicked()
    {
        if (active)
        {
            GameObject.SetActive(false);
            active = false;
        }
        else
        {
            GameObject.SetActive(true);
            active = true;
        }
    }
    public void Start()
    {
        position = GameObject.transform.position;
        rotation = GameObject.transform.rotation;
        data = GameObject.transform.localScale;
    }
    public void ButtonReset()
    {
        Debug.Log("Button gedrückt");
        GameObject.transform.position = position;
        GameObject.transform.rotation = rotation;
        GameObject.transform.localScale = data;
    }

}
