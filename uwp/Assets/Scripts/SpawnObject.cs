using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

    Vector3 initialPosition;
    //public ModelBank.ModelBank bank = new ModelBank.ModelBank("Chemistry");

    // Use this for initialization
    void Start () {
        //bank.makeBook("D:/Libraries/HoloScholar/Assets/ModelManifest.txt");
        //bank.makePages("D:/Libraries/HoloScholar/Assets/PageManifest.txt");
        initialPosition = this.gameObject.transform.localPosition;
    }
	void ScaleDown()
    {
        //string path = bank.GetUnityPath(0, 0);
        string path = "Models/buckyball";
        GameObject loadedObj = Resources.Load(path) as GameObject;
        GameObject object1 = Instantiate(loadedObj) as GameObject;
        object1.transform.localPosition = initialPosition;
        object1.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        this.transform.localScale = new Vector3(0, 0, 0);
    }
    void ScaleUp()
    {

    }
}

