using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LayoutUpdater : MonoBehaviour
{
    int updateCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        //rt = gameObject.GetComponent<RectTransform>();

        //Vector3 currentPosition = gameObject.GetComponent<RectTransform>().position;
        //gameObject.GetComponent<RectTransform>().position = new Vector3(currentPosition.x, currentPosition.y + 300, currentPosition.z);
        //Debug.Log(gameObject.name + " " + gameObject.GetComponent<RectTransform>().position.x + " " + gameObject.GetComponent<RectTransform>().position.y);

        //GameObject table = gameObject.transform.GetChild(0).GetChild(2).gameObject;
        //GameObject row = table.transform.GetChild(0).gameObject;

        //GameObject copy = Instantiate(row);
        //copy.transform.parent = table.transform;
        //copy.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "TEST";
        //row.SetActive(false);

        //LayoutRebuilder.MarkLayoutForRebuild(GetComponent<RectTransform>());
        //Debug.Log("Layout rebuilt.");
    }

    private void Update()
    {
        //int limit = 2;
        //if (updateCounter < limit)
        //    updateCounter++;
        //if (updateCounter == limit)
        //{
        //    RectTransform rt = gameObject.GetComponent<RectTransform>();
        //    rt.sizeDelta = new Vector2(rt.rect.width - 500, rt.rect.height);
        //    updateCounter++;
        //    Debug.Log("Done");
        //}

        //float width = rt.rect.width;

        //if (width < 300)
        //{
        //    switcher = false;
        //}
        //else if (width > 1000)
        //{
        //    switcher = true;
        //}

        //if (switcher)
        //{
        //    rt.sizeDelta = new Vector2(width - 1, rt.rect.height);
        //}
        //else
        //{
        //    rt.sizeDelta = new Vector2(width + 1, rt.rect.height);
        //}
    }
}
