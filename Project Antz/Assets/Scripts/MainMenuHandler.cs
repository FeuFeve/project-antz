using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainMenuHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public static bool inMainMenu = false;

    [SerializeField] private GameObject currentMainMenu;
    [SerializeField] private GameObject linkedSubMenu;

    public void OnPointerEnter(PointerEventData eventData)
    {
        inMainMenu = true;
        SecondaryMenuHandler.inSecondaryMenu = true;
        currentMainMenu.GetComponent<Button>().Select();
        //currentMainMenu.SetActive(true);
        linkedSubMenu.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        inMainMenu = false;
        if(!SecondaryMenuHandler.inSecondaryMenu)
        {
            //currentMainMenu.SetActive(false);
            EventSystem.current.SetSelectedGameObject(null);
            linkedSubMenu.SetActive(false);
        }
    }
}
