using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
[ExecuteInEditMode]
public class NodeConnector : MonoBehaviour
{
    public RectTransform startPos;
    public RectTransform endPos;

    private void Update()
    {
        if (!startPos)
        {
            throw new System.Exception("startPos Not Set");
        }
        if (!endPos)
        {
            throw new System.Exception("endPos Not Set");
        }


        RectTransform tf = GetComponent<RectTransform>();
        handlePosition(tf);
        handleStretching(tf);
        handleRotation(tf);
    }

    private void handlePosition(RectTransform tf)
    {
        tf.position = (startPos.position + endPos.position) / 2;
    }

    private void handleStretching(RectTransform tf)
    {
        float connectionLength = Vector3.Distance(startPos.localPosition, endPos.localPosition);
        tf.sizeDelta = new Vector2(tf.rect.width, connectionLength);
    }

    private void handleRotation(RectTransform tf)
    {
        Vector3 targetRot = endPos.position - startPos.position;
        targetRot.Normalize();
        float rotX = Mathf.Atan2(targetRot.y, targetRot.x) * Mathf.Rad2Deg + 90;
        tf.localRotation = Quaternion.Euler(0, 0, rotX);
    }
} 
#endif
