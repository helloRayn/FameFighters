using UnityEngine;
using System.Collections;

public class Town_Code : MonoBehaviour {

    public Player_Move Player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        /*if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray)) onclick();
        }*/
	}
    void onclick () {

        Debug.Log("target.x.ToString");
    }
    void OnMouseDown(){

        Player.New_target(this.transform.position);
        onclick();

    }
}
