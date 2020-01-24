using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SecondaryMenuHandler : MonoBehaviour, IPointerExitHandler
{
    public static bool inSecondaryMenu = false;

    [SerializeField] private GameObject linkedMainMenu;
    [SerializeField] private GameObject currentSecondaryMenu;

    public void OnPointerExit(PointerEventData eventData)
    {
        inSecondaryMenu = false;
        if(!MainMenuHandler.inMainMenu)
        {
            //linkedMainMenu.SetActive(false);
            EventSystem.current.SetSelectedGameObject(null);
            currentSecondaryMenu.SetActive(false);
        }
    }
}
