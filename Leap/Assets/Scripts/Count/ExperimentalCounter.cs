using System.Collections;

using UnityEngine;
using UnityEngine.Events;

public class ExperimentalCounter : MonoBehaviour
{
    public UnityEvent OnCount;

    public float seconds = 2.0f;
    public int numbers = 30;

    IEnumerator Start()
    {
        while (numbers > 0)
        {
            OnCount.Invoke();
            yield return new WaitForSeconds(seconds);
            numbers--;
        }
    }
}