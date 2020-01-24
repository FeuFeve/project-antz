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
        linkedSubMenu.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        inMainMenu = false;

        RectTransform imgRectTransform = linkedSubMenu.GetComponent<RectTransform>();
        Vector2 localMousePosition = imgRectTransform.InverseTransformPoint(Input.mousePosition);

        if (!imgRectTransform.rect.Contains(localMousePosition))
        {
            EventSystem.current.SetSelectedGameObject(null);
            linkedSubMenu.SetActive(false);
        }
    }
}
