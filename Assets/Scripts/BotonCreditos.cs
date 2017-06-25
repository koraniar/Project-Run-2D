using UnityEngine;
using System.Collections;

public class BotonCreditos : MonoBehaviour {

	public string nombreEscenaParaCargar = "CreditScene";
	public static Camera mainCamera;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown(){
		Application.LoadLevel (nombreEscenaParaCargar);
		}
	}
