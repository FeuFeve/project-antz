using UnityEngine;

public class PageLoader : MonoBehaviour
{
    [SerializeField] private GameObject startingPage;
    public static GameObject currentPage;

    void Start()
    {
        currentPage = startingPage;
        currentPage.SetActive(true);
    }

    public void SwitchToPage(GameObject pageToLoad)
    {
        currentPage.SetActive(false);
        pageToLoad.SetActive(true);
        currentPage = pageToLoad;
    }
}
