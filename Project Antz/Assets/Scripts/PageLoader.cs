using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageLoader : MonoBehaviour
{
    [SerializeField]
    List<GameObject> currentlyDisplayedGameObjects;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject gameObject in currentlyDisplayedGameObjects)
        {
            gameObject.SetActive(true);
        }
    }

    // Deactivate all GameObjects and remove them from the list
    public void ResetActiveGameObjects()
    {
        foreach(GameObject gameObject in currentlyDisplayedGameObjects)
        {
            gameObject.SetActive(false);
        }
        currentlyDisplayedGameObjects.Clear();
    }

    // Add a GameObject to the list and activate it
    public void ActivateGameObject(GameObject gameObject)
    {
        currentlyDisplayedGameObjects.Add(gameObject);
        gameObject.SetActive(true);
    }
}
