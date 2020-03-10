using UnityEngine;

public class Zoom : MonoBehaviour
{
    [SerializeField] float minSize = 0.5f;
    [SerializeField] float maxSize = 1.5f;

    [SerializeField] private float zoomRate = 3;

    Vector3 difference;
    Vector3 mousePos;

    private void Update()
    {
        float scrollWheel = -Input.GetAxis("Mouse ScrollWheel");

        if (scrollWheel != 0)
        {
            ChangeZoom(scrollWheel);
        }
    }

    private void ChangeZoom(float scrollWheel)
    {
        float rate = 1 + zoomRate * Time.unscaledDeltaTime;
        if (scrollWheel > 0 && transform.localScale.y > minSize)
        {
            mousePos = Input.mousePosition;
            SetZoom(Mathf.Clamp(transform.localScale.y / rate, minSize, maxSize));
            difference = transform.position - mousePos;
            transform.position = mousePos + (difference * 0.9F);
        }
        else if (scrollWheel < 0 && transform.localScale.y < maxSize)
        {
            mousePos = Input.mousePosition;
            SetZoom(Mathf.Clamp(transform.localScale.y * rate, minSize, maxSize));
            difference = transform.position - mousePos;
            transform.position = mousePos + (difference * 1.11F);
        }
    }

    private void SetZoom(float targetSize)
    {
        transform.localScale = new Vector3(targetSize, targetSize, 1);
    }
}