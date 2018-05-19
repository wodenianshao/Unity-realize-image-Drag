using UnityEngine;
using System.Collections;

public class InPutController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(!Application.isMobilePlatform)
        {
            if(Input.GetMouseButtonUp(0))  //Input.GetKeyDown(KeyCode.A)
            {
                GetComponent<CubeGenerator>().Generator();
            }
        }
	
	}
}
