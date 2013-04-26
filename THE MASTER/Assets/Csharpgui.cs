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
		
		Texture2D boxcolor=new Texture2D(1,1);
		boxcolor.SetPixels(0, 0, 1, 1, new Color[1] {Colorhealth} );  
		GUI.color = Colorhealth;
		GUIStyle Healthstyle = new GUIStyle();
		Healthstyle.normal.background = boxcolor;
		GUI.Box(new Rect(1 + hp,10,50 + 3 * hp,50), ""+hp, Healthstyle);
		Debug.Log (GameObject.Find("Player").GetComponent<Controller>().hp ); 
	}
	void Update () {
	
	}
}

