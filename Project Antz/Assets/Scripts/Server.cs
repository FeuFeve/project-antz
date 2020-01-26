using System.Collections.Generic;
using UnityEngine;

public class Server : MonoBehaviour
{
    public const int serverMapSizeX = 100;
    public const int serverMapSizeY = 100;

    public Map map;

    public List<Player> players;



    // Start is called before the first frame update
    void Start()
    {
        Laying.CalculateSecondsPerUnit(300, 7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
