using UnityEngine;

public class Zoom : MonoBehaviour
{
    [SerializeField] float m_MinSize = 0.5f;
    [SerializeField] float m_MaxSize = 1.5f;

    [SerializeField] private float zoomRate = 3;

    Vector3 m_Difference;
    Vector3 m_MousePos;

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
        if (scrollWheel > 0 && transform.localScale.y > m_MinSize)
        {
            m_MousePos = Input.mousePosition;
            SetZoom(Mathf.Clamp(transform.localScale.y / rate, m_MinSize, m_MaxSize));
            m_Difference = transform.position - m_MousePos;
            transform.position = m_MousePos + (m_Difference * 0.9F);
        }
        else if (scrollWheel < 0 && transform.localScale.y < m_MaxSize)
        {
            m_MousePos = Input.mousePosition;
            SetZoom(Mathf.Clamp(transform.localScale.y * rate, m_MinSize, m_MaxSize));
            m_Difference = transform.position - m_MousePos;
            transform.position = m_MousePos + (m_Difference * 1.11F);
        }
    }

    private void SetZoom(float targetSize)
    {
        transform.localScale = new Vector3(targetSize, targetSize, 1);
    }
}