using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SubLoader : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] GameObject secondaryMenu;
    [SerializeField] GameObject currentMenu;

    List<GameObject> menus = new List<GameObject>();

    void Start()
    {
        //GameObject test = transform.Find("Secondary Menus").gameObject;
        int numberOfChilds = secondaryMenu.transform.childCount;
        for (int i = 0; i < numberOfChilds; i++)
        {
            menus.Add(secondaryMenu.transform.GetChild(i).gameObject);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Entered a menu box.");
        foreach(GameObject menu in menus)
        {
            menu.SetActive(false);
        }

        currentMenu.SetActive(true);
    }


    //[SerializeField] GameObject toActivate;
    //public static GameObject toDeactivate;

    //public void OnMouseEnter()
    //{
    //    toDeactivate.SetActive(false);
    //    toActivate.SetActive(true);
    //    toDeactivate = toActivate;
    //}
}
