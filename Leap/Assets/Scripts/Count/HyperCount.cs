using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HyperCount : MonoBehaviour
{

    private Text label;

    IEnumerator Start()
    {
        label = GetComponent<Text>();

        int number = 3;

        while (number > 0)
        {
            //	yield return new WaitForSeconds(0.01f);    <-runs faster
            yield return new WaitForSeconds(1);
            label.text = number.ToString();
            number--;
        }
        label.text = "1";
        yield return new WaitForSeconds(1);
        label.text = "JUMP TO SURVIVE";
        yield return new WaitForSeconds(2);
        label.text = "HIT THE ORBS FOR POINTS";
        yield return new WaitForSeconds(3);
        label.text = "DODGE PILLARS";
        yield return new WaitForSeconds(4);
        label.text = "";
    }
}