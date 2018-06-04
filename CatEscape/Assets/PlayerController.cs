using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	void Start () {
	}

    public void LButtoDown()
    {
        transform.Translate(-3, 0, 0);
    }

    public void RButtoDown()
    {
        transform.Translate(3, 0, 0);
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);
        }
		
	}
}
