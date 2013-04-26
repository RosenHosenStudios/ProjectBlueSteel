using UnityEngine;
using System.Collections;

public class Csharpgui : MonoBehaviour {

	void Start () {
	
        
    }		
	
	void OnGUI () {
		int hp= GameObject.Find("Player").GetComponent<Controller>().hp;
		//Defining color based on hp such that red value increases as green value decreases
		Color Colorhealth = GUI.color;
		Colorhealth.r=(100- (float) hp)/100; 
		Colorhealth.g=((float) hp)/100; 
		Colorhealth.b= 0; 
		//Creates a 1 pixel by 1 pixel texture and spreads it over the background box, coloring it according to the hp value.
		Texture2D boxcolor=new Texture2D(1,1);
		boxcolor.SetPixels(0, 0, 1, 1, new Color[1] {Colorhealth} );  
		GUI.color = Colorhealth;
		GUIStyle Healthstyle = new GUIStyle();
		Healthstyle.normal.background = boxcolor;
		//Defines the size of the box based on health remaining
		GUI.Box(new Rect(10,10,50 + 3 * hp,50), "", Healthstyle);
		Debug.Log (GameObject.Find("Player").GetComponent<Controller>().hp ); 
	}
	void Update () {
	
	}
}

