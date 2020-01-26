using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{
    public GameObject startingPage = null;
    bool updated = false;
    int counter = 0;
    int limit = 50;

    // Start is called before the first frame update
    void Start()
    {
        startingPage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!updated)
        {
            startingPage.SetActive(false);
            if (counter == limit)
            {
                startingPage.SetActive(true);
                updated = true;
            }
            else if (counter < limit)
                counter++;
        }
    }
}
