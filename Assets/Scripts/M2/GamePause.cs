using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
		Time.timeScale = 0;    
    }

    // Update is called once per frame
    void Update()
    {

		if (Input.GetKeyUp(KeyCode.P)) {
			if (Time.timeScale != 0) {
				Time.timeScale = 0;
			} else {
				Time.timeScale = 1;
			}
		}
    }
}
