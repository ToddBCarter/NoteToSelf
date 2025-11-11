using UnityEngine;
using System.Collections;

public class TheScriptofLittleGuy : MonoBehaviour
{
	[SerializeField]
	int RotateSpeed = 1;
    
	// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		LookAround();
    }
	
	IEnumerator LookAround(){
		//float StartingAngle = GetComponent<Transform>().position.x;
		//float RotateAmount = Random.Range(0, 60);
		//print(RotateAmount);
		//while(GetComponent<Transform>().position.x != StartingAngle + RotateAmount){
			GetComponent<Transform>().Rotate(0, 0, 10);
		//}
		yield return new WaitForSeconds(1);
	}
}
