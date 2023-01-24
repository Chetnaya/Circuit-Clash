using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    // public GameObject player;
    // public Vector3 offset = new Vector3(0 ,5, -7);

    public GameObject MainCamera01;
    public GameObject MainCamera02;
    public GameObject FrontviewCamera01;
    public GameObject FrontviewCamera02;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Switch1"))
        {
            MainCamera01.SetActive(true);
            MainCamera02.SetActive(true);
            FrontviewCamera01.SetActive(false);
            FrontviewCamera02.SetActive(false);
        
        }
        if(Input.GetButtonDown("Switch2"))
        {
            MainCamera01.SetActive(false);
            MainCamera02.SetActive(false);
            FrontviewCamera01.SetActive(true);
            FrontviewCamera02.SetActive(true);
        }
    }
}
