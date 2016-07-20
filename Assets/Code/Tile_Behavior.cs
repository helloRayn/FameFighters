using UnityEngine;
using System.Collections;

public class Tile_Behavior : MonoBehaviour {


    public Tile_Behavior north;
    public Tile_Behavior south;
    public Tile_Behavior east;
    public Tile_Behavior west;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public Tile_Behavior Get_north() {

        return north;
    }

    public Tile_Behavior Get_south()
    {

        return south;
    }

    public Tile_Behavior Get_east()
    {

        return east;
    }

    public Tile_Behavior Get_west()
    {

        return west;
    }
}
