using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeToBlack : MonoBehaviour
{
    public float targetValue = 0;
    CanvasRenderer elementToFade;
    void Start()
    {
        elementToFade = gameObject.GetComponent<CanvasRenderer>();
        StartCoroutine(LerpFunction(targetValue, 0.8f));
    }
    IEnumerator LerpFunction(float endValue, float duration)
    {
        while (true)
        {
            float time = 0;
            float startValue = elementToFade.GetAlpha();
            // 淡出
            while (time < duration)
            {
                elementToFade.SetAlpha(Mathf.Lerp(startValue, endValue, time / duration));
                time += Time.deltaTime;
                yield return null;
            }
            elementToFade.SetAlpha(endValue);
        
            // 淡入
            time = 0;
            while (time < duration)
            {
                elementToFade.SetAlpha(Mathf.Lerp(endValue, startValue, time / duration));
                time += Time.deltaTime;
                yield return null;
            }
           elementToFade.SetAlpha(startValue);
        }
    }

}
