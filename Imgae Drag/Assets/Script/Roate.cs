using UnityEngine;
using System.Collections;

public class Roate : MonoBehaviour {

    public float roateSpeed;
    public int num = 0;
    public float total = 0.0f;
    // Use this for initialization
    void Start () {
        roateSpeed = 10.0f;
	}
	
	// Update is called once per frame
	void Update () {
        //print(Time.deltaTime);
        total = total + Time.deltaTime;
        if (total >= 1.0f)
        {
            num = num + 1;
            total = 0.0f;
            print(num);
        }
        float yAngle = roateSpeed * Time.deltaTime;
        transform.Rotate(0.0f,yAngle,0.0f);
	}
}
