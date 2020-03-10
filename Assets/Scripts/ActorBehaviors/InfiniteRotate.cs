using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteRotate : MonoBehaviour
{
    private Transform m_tf;
    [SerializeField]
    private float rotateSpeed = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        m_tf = GetComponent<Transform>();
        m_tf.Rotate(m_tf.forward, Random.Range(0, 360.0f));
    }

    // Update is called once per frame
    void Update()
    {
        // Spinning SFX
        m_tf.Rotate(new Vector3(0, 0, 1), rotateSpeed * Time.deltaTime);
    }
}

