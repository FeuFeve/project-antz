using System.Collections.Generic;

public class Map
{
    public int sizeX;
    public int sizeY;

    public List<Coordinates> coordinates;
    public List<Coordinates> availableCoordinates;


    // CONSTRUCTOR
    public Map(int sizeX, int sizeY)
    {
        this.sizeX = sizeX;
        this.sizeY = sizeY;

        for(int x = 0; x < sizeX; x++)
        {
            for(int y = 0; y < sizeY; y++)
            {
                coordinates.Add(new Coordinates(x, y));
            }
        }

        availableCoordinates = coordinates;
    }


    // GET THE FIRST AVAILABLE COORDINATES FOR A PLAYER IN THE MAP
    public Coordinates GetAvailableCoords()
    {
        if (availableCoordinates.Count > 0)
        {
            return availableCoordinates[0];
        }
        return null;
    }
}
