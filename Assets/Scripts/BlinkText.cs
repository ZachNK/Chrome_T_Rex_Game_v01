using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BlinkText : MonoBehaviour
{
    private float blinkOut = 0.5f;
    private Text expl;

    // Start is called before the first frame update
    private void Start()
    {
        expl = GetComponent<Text>();
        StartCoroutine(Blinking());
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private IEnumerator Blinking()
    {
        while (true)
        {
            expl.text = " ";
            yield return new WaitForSeconds(blinkOut);
            expl.text = "<--- Hit Legs to Jump";
            yield return new WaitForSeconds(2f);
        }
    }
}