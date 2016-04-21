using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {

	int counter = 0;
	public GameObject Cube1;
	public GameObject Cube2;
	public GameObject Cube3;
	public GameObject Cube4;
	public GameObject Cube5;
	public GameObject Cube6;
	public GameObject Cube7;
	public GameObject Cube8;
	public GameObject Cube9;
	Renderer rn1;
	Renderer rn2;
	Renderer rn3;
	Renderer rn4;
	Renderer rn5;
	Renderer rn6;
	Renderer rn7;
	Renderer rn8;
	Renderer rn9;
	Color  col1;
	Color  col2;
	Color  col3;
	Color  col4;
	Color  col5;
	Color  col6;
	Color  col7;
	Color  col8;
	Color  col9;

	void Start(){
		rn1 = Cube1.GetComponent<Renderer>();
		rn2 = Cube2.GetComponent<Renderer>();
		rn3 = Cube3.GetComponent<Renderer>();
		rn4 = Cube4.GetComponent<Renderer>();
		rn5 = Cube5.GetComponent<Renderer>();
		rn6 = Cube6.GetComponent<Renderer>();
		rn7 = Cube7.GetComponent<Renderer>();
		rn8 = Cube8.GetComponent<Renderer>();
		rn9 = Cube9.GetComponent<Renderer>();
		col1 = rn1.material.color;
		col2 = rn2.material.color;
		col3 = rn3.material.color;
		col4 = rn4.material.color;
		col5 = rn5.material.color;
		col6 = rn6.material.color;
		col7 = rn7.material.color;
		col8 = rn8.material.color;
		col9 = rn9.material.color;
	}

	public void Change(){
		if (counter == 0) {
			newColor ();
			counter = 1;
		} else {
			oldColor ();
			counter = 0;
		}
	}

	void oldColor(){
		rn1.material.color = col1;
		rn2.material.color = col2;
		rn3.material.color = col3;
		rn4.material.color = col4;
		rn5.material.color = col5;
		rn6.material.color = col6;
		rn7.material.color = col7;
		rn8.material.color = col8;
		rn9.material.color = col9;
	}

	void newColor(){
		rn1.material.color = Color.gray;
		rn2.material.color = Color.gray;
		rn3.material.color = Color.gray;
		rn4.material.color = Color.green;
		rn5.material.color = Color.green;
		rn6.material.color = Color.green;
		rn7.material.color = Color.white;
		rn8.material.color = Color.white;
		rn9.material.color = Color.white;
	}
}
