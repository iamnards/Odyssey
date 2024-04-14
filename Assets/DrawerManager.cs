using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DrawerManager : MonoBehaviour
{
    [SerializeField] GameObject drawerParent;
    [SerializeField] Vector2 closedPosition, openPosition;
    [SerializeField] AnimationCurve animationCurve;

    public Button b1;
    public TextMeshProUGUI b1text;

    private RectTransform m_RT;
    private float endTime;
    private bool isOpen = false;

    void Start()
    {
        b1text = b1.GetComponentInChildren<TextMeshProUGUI>();
        FindFurthestKeyFrame();
        m_RT = GetComponent<RectTransform>();
        closedPosition = m_RT.anchoredPosition;
    }

    public void ToggleDrawer()
    {
        if (isOpen)
        {
            StartCoroutine(CloseRoutine());
            b1text.text = "^";
        }
        else
        {
            StartCoroutine(OpenRoutine());
            b1text.text = "v";
        }
    }


    private IEnumerator OpenRoutine()
    {
        float elapsedTime = 0;
        while (elapsedTime < endTime)
        {
            m_RT.anchoredPosition = Vector3.Lerp(closedPosition, openPosition, animationCurve.Evaluate(elapsedTime));
            yield return new WaitForEndOfFrame();
            elapsedTime += Time.deltaTime;
        }
        isOpen = true;
    }

    private IEnumerator CloseRoutine()
    {
        float elapsedTime = 0;
        while (elapsedTime < endTime)
        {
            m_RT.anchoredPosition = Vector3.Lerp(openPosition, closedPosition, animationCurve.Evaluate(elapsedTime));
            yield return new WaitForEndOfFrame();
            elapsedTime += Time.deltaTime;
        }
        isOpen = false;
    }


    private void FindFurthestKeyFrame()
    {
        float maxTime = Mathf.NegativeInfinity;
        foreach (Keyframe frame in animationCurve.keys)
        {
            if (frame.time > maxTime)
            {
                maxTime = frame.time;

            }
        }
        endTime = maxTime;
    }
}
