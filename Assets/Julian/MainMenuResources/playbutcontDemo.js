#pragma strict

var Furry: GameObject;

function OnMouseEnter()
{	//Debug.Log("mouse enter");

	Furry.SetActive(true);
//GetComponent(SpriteRenderer).sprite = Button_Down;
}

function OnMouseExit()
{	//Debug.Log("mouse exit");

			Furry.SetActive(false);

//GetComponent(SpriteRenderer).sprite = Button;
}

function OnMouseDown()
{
	Application.LoadLevel("Demo 1");
}