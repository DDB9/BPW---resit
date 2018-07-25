using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

    public float speed;
    private Rigidbody player;

    void Start (){
        player = GetComponent<Rigidbody>();
    }

    void FixedUpdate (){
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        player.AddForce (movement * speed);
    }
}