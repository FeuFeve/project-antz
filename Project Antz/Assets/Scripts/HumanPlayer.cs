using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HumanPlayer : Player
{
    public TextMeshProUGUI profile;
    public TextMeshProUGUI profile2;


    // CONSTRUCTOR
    public HumanPlayer(int id, string pseudo, Coordinates coords) : base(id, pseudo, coords)
    {

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        profile.text    = "ID : " + id + "\n"
                        + "Pseudo : " + pseudo;
        profile2.text = profile.text;
    }
}
