using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageLoader : MonoBehaviour
{
    [SerializeField] private List<GameObject> deactivatePagesInside;
    [SerializeField] private GameObject startingPage;
    public static GameObject currentPage;


    void Start()
    {
        // Deactivate all pages of the different folders
        foreach(GameObject pageFolder in deactivatePagesInside)
        {
            foreach(Transform page in pageFolder.transform)
            {
                page.gameObject.SetActive(false);
            }
            pageFolder.SetActive(false);
        }

        // Activate the Welcome Page if it's not already the case
        currentPage = startingPage;
        currentPage.SetActive(true);
        currentPage.transform.parent.gameObject.SetActive(true);
    }

    // SWITCH FROM A PAGE TO ANOTHER
    public void SwitchToPage(GameObject pageToLoad)
    {
        currentPage.SetActive(false);
        currentPage.transform.parent.gameObject.SetActive(false);
        pageToLoad.SetActive(true);
        pageToLoad.transform.parent.gameObject.SetActive(true);
        currentPage = pageToLoad;
    }
}
