using UnityEngine;
using System.Collections;

public class MemoryCard : MonoBehaviour 
{
	[SerializeField] private SceneController controller;
	private int _id;
	public int id 
	{
		get {return _id;}
	}
	public void SetCard(int id, Sprite image) 
	{
		_id = id;
		GetComponent<SpriteRenderer>().sprite = image;
	}

	[SerializeField] private GameObject upsite;
	public void OnMouseDown() 
	{
		if (upsite.activeSelf && controller.canReveal) {
			upsite.SetActive(false);
			controller.CardRevealed(this);
		}
	}
	public void Unreveal() 
	{
		upsite.SetActive(true);
	}
}