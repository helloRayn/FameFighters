using UnityEngine;
using System.Collections;

public class Player_Move : MonoBehaviour
{

    Vector2 target = Vector2.zero;

    public Tile_Behavior current_tile;

    // Use this for initialization
    void Start()
    {
        target = this.transform.position;
        target = current_tile.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        this.transform.position = Vector3.MoveTowards(this.transform.position, target, 1f);

        if (Input.GetKey(KeyCode.LeftArrow) && this.transform.position.x == target.x && this.transform.position.y == target.y)
        {

            Tile_Behavior New_tile = current_tile.Get_west();
            if (!(New_tile.CompareTag("Impassable"))) {

                current_tile = current_tile.Get_west();
                target = current_tile.transform.position;
            }

            /*Vector3 position = this.transform.position;
            position.x = position.x - 0.1f;
            this.transform.position = position;*/
        }
        if (Input.GetKey(KeyCode.RightArrow) && this.transform.position.x == target.x && this.transform.position.y == target.y)
        {

            Tile_Behavior New_tile = current_tile.Get_east();
            if (!(New_tile.CompareTag("Impassable"))) {

                current_tile = current_tile.Get_east();
                target = current_tile.transform.position;
            }

            /*Vector3 position = this.transform.position;
            position.x = position.x + 0.1f;
            this.transform.position = position;*/
        }
        if (Input.GetKey(KeyCode.UpArrow) && this.transform.position.x == target.x && this.transform.position.y == target.y)
        {

                Tile_Behavior New_tile = current_tile.Get_north();
                if (!(New_tile.CompareTag("Impassable"))) {

                    current_tile = current_tile.Get_north();
                    target = current_tile.transform.position;
                }

            /*Vector3 position = this.transform.position;
            position.y = position.y + 0.1f;
            this.transform.position = position;*/
        }
        if (Input.GetKey(KeyCode.DownArrow) && this.transform.position.x == target.x && this.transform.position.y == target.y)
        {

                    Tile_Behavior New_tile = current_tile.Get_south();
                if (!(New_tile.CompareTag("Impassable"))) {

                    current_tile = current_tile.Get_south();
                    target = current_tile.transform.position;
                }

            /*Vector3 position = this.transform.position;
            position.y = position.y - 0.1f;
            this.transform.position = position;*/
        }
    }
    public void New_target(Vector2 nTarget) {

        target = nTarget;
    }

    public Vector2 Get_target() {

        return target;
        }
}

