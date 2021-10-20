using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class SetAllObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("Editor causes this Awake");




        //foreach (var item in transform.GetComponentsInChildren<SpriteRenderer>())
        //{
        //        print(item.GetComponent<SpriteRenderer>().sortingLayerName);
        //    if(item.GetComponent<SpriteRenderer>().sortingLayerName == "Default")
        //    {
        //        item.GetComponent<SpriteRenderer>().sortingLayerName = "Front";
        //    }
        //}
    }


}
