using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObj3 : MonoBehaviour
{

    Vector3 initialPosition;

    // Use this for initialization
    void Start()
    {
        initialPosition = this.gameObject.transform.localPosition;
    }
    void ScaleDown()
    {
        GameObject loadedObj = Resources.Load("Models/buckyball") as GameObject;
        GameObject object1 = Instantiate(loadedObj) as GameObject;
        object1.transform.localPosition = initialPosition;
        object1.transform.localScale = new Vector3(20, 20, 20);
        this.transform.localScale = new Vector3(0, 0, 0);
    }
    void ScaleUp()
    {

    }
}

