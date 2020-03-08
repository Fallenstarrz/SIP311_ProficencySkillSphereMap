using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceUp : MonoBehaviour
{
    Transform tf;
    [SerializeField]Quaternion defaultRot;

    // Use this for initialization
    void Start()
    {
        tf = GetComponent<Transform>();
        defaultRot = new Quaternion(0,0,0,1);
    }

    // Update is called once per frame
    void Update()
    {
        tf.rotation = defaultRot;
    }
}
