using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaciones : MonoBehaviour{
    Animator animator;

    void Awake () {
        animator = GetComponent<Animator> ();
    }

    void Update () {
        bool caminar = Input.GetKey (KeyCode.LeftControl);
            animator.SetBool ("Caminar", caminar);

        if (Input.GetKey (KeyCode.Space)) {
            animator.SetTrigger ("Atacar");
        }
    }
}
