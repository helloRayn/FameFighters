using UnityEngine;
using System.Collections;

public class Town_Code : MonoBehaviour {

    public Player_Move Player;

    public Canvas UI;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if ((Player.Get_target().x == this.transform.position.x) && (Player.Get_target().y == this.transform.position.y)) {

            if (!(UI.isActiveAndEnabled) && Player.transform.position.x == this.transform.position.x && Player.transform.position.y == this.transform.position.y) {

                UI.enabled = true;
                Debug.Log("Player here");
            }

            if (UI.isActiveAndEnabled && Player.transform.position.x != this.transform.position.x && Player.transform.position.y != this.transform.position.y) {

                UI.enabled = false;
                Debug.Log("Player not here");
            }
        }
    }
    void onclick () {

        Debug.Log("target.x.ToString");
    }
    void OnMouseDown(){

        Player.New_target(this.transform.position);
        onclick();

    }
}
