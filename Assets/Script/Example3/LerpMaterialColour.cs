using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LerpMaterialColour : MonoBehaviour
{
    
    private Text text;
    public Color targetColor = new Color(0, 1, 0, 1); 
    void Start()
    {
        text = gameObject.GetComponent<Text>();
        StartCoroutine(LerpFunctionWhile(targetColor, 5));
    }
    IEnumerator LerpFunction(Color endValue, float duration)
    {
        float time = 0;
        Color startValue = text.color;
        while (time < duration)
        {
            text.color = Color.Lerp(startValue, endValue, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        text.color = endValue;
    }
    
    IEnumerator LerpFunctionWhile(Color endValue, float duration)
    {
        var start = text.color;
        var end = endValue;
        while (true)
        {
            float time = 0;
            Color startValue = text.color;
            var temp = text.color;
            while (time < duration)
            {
                text.color = Color.Lerp(startValue, endValue, time / duration);
                time += Time.deltaTime;
                yield return null;
            }
            text.color = endValue;
        
            time = 0;
            startValue = text.color;
            while (time < duration)
            {
                text.color = Color.Lerp(startValue, temp, time / duration);
                time += Time.deltaTime;
                yield return null;
            }
            text.color = temp;
        }
    }
}
