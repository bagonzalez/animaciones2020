using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterMove : MonoBehaviour
{
    public float vMove = 5.0f;
    public float vRotation = 200.0f;
    private Animator animator;
    public float x, y;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.Rotate(0, x*Time.deltaTime*vRotation,0);
        transform.Translate(0, 0, y * Time.deltaTime * vMove);
        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);
    }
}
