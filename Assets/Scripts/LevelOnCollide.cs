using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelOnCollide : MonoBehaviour{
    public Text text;

    void Start()
    {
        text.gameObject.SetActive(false);
        text.color = new Color(0, 0, 0, 0);
    }

    void Update()
    {

    }
    void OnTriggerEnter(Collider other){
        text.gameObject.SetActive(true);
        text.color = new Color(0, 0, 0, 1);
    }
}
