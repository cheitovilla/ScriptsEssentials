using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorMaterial : MonoBehaviour {

	public Color altColor = Color.black;
	public Renderer rend; 
	//I do not know why you need this?
	void Example() {         
		altColor.g = 0f;         
		altColor.r = 0f;        
		altColor.b = 0f;         
		altColor.a = 0f;     
	}      
	void Start ()
	{       
		//Ejemplo de llamada para establecer todos los valores de color a cero.
		Example();
		//Llamamos el componente Renderer para poder acceder al color
		rend = GetComponent<Renderer>();
		//Establecemos el color inicial (0f,0f,0f,0f)
		rend.material.color = altColor;
	}      
	void Update() 
	{
		if (Input.GetKeyDown (KeyCode.G)){  
			//Alterar el color          
			altColor.g += 0.1f;
			//Asignar el cambio de color al material
			rend.material.color = altColor;
		}
		if (Input.GetKeyDown (KeyCode.R)){  
			//Alterar el color           
			altColor.r += 0.1f;
			//Asignar el cambio de color al material
			rend.material.color = altColor;
		}
		if (Input.GetKeyDown (KeyCode.B)){  
			//Alterar el color            
			altColor.b += 0.1f;
			//Asignar el cambio de color al material
			rend.material.color = altColor;
		}
		if (Input.GetKeyDown (KeyCode.A)){ 
			//Alterar el color            
			altColor.a += 0.1f;
			//Asignar el cambio de color al material
			rend.material.color = altColor;
		}
	}   
}
