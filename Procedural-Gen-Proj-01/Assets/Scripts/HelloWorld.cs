using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelloWorld : MonoBehaviour {

    public string[] hellos = new string[4] {
        "Hello World", "Hola Mundo",
        "Bonjour Le Monde", "Hallo Welt"};

    public TextMeshProUGUI textString;  

	// Use this for initialization
	void Start () {
        Random.seed = (int)System.DateTime.Now.Ticks;
        int randomIndex = Random.Range(0, hellos.Length);
        textString.text = hellos[randomIndex];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
