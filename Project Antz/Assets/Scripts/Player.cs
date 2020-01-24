using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    // General data
    public int id;
    public string pseudo;
    public DateTime creationDate;

    // Coordinates
    public Coordinates coords;

    // Troops
    public Troops troops;


    // CONSTRUCTOR
    public Player(int id, string pseudo, Coordinates coords)
    {
        this.id = id;
        this.pseudo = pseudo;
        creationDate = DateTime.Now;

        this.coords = coords;

        troops = new Troops();
    }
}
