using UnityEngine;
using System.Collections;

public class Player_Move : MonoBehaviour
{

    Vector2 target = Vector2.zero;

    // Use this for initialization
    void Start()
    {
        target = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        this.transform.position = Vector3.MoveTowards(this.transform.position, target, 0.1f);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x = position.x - 0.1f;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x = position.x + 0.1f;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.y = position.y + 0.1f;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.y = position.y - 0.1f;
            this.transform.position = position;
        }
    }
    public void New_target (Vector2 nTarget) {

        target = nTarget;
    }
}

