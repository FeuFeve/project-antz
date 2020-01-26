using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LayoutUpdater : MonoBehaviour
{
    int counter;
    int limit = 1;

    void Start()
    {
        
    }

    void Update()
    {
        if (counter == limit)
        {
            Vector2 temporaryVector = new Vector2(1, 0);
            GetComponent<RectTransform>().sizeDelta += temporaryVector;
            GetComponent<RectTransform>().sizeDelta -= temporaryVector;
            Debug.Log("Done");
        }
        if (counter <= limit)
            counter++;
    }
}
