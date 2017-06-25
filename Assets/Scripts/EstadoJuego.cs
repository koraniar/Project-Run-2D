using UnityEngine;
using System.Collections;
using System;
using System.IO;

public class EstadoJuego : MonoBehaviour {

	public int puntuacionMaxima = 0;

	public static EstadoJuego estadoJuego;

	void Awake(){
		if(estadoJuego==null){
			estadoJuego = this;
			DontDestroyOnLoad(gameObject);
		}else if(estadoJuego!=this){
			Destroy(gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		Cargar();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void Guardar(){
		PlayerPrefs.SetInt("puntuacionMaxima", estadoJuego.puntuacionMaxima);
	}
	
	void Cargar(){
		puntuacionMaxima = PlayerPrefs.GetInt("puntuacionMaxima", 0);
	}
}