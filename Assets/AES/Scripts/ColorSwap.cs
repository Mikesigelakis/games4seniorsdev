using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwap : MonoBehaviour
{
	public bool color;
	[SerializeField] private Color32 _normalColor = new Color(100, 100, 100);
	[SerializeField] private Color32 _activeColor = new Color(255, 255, 255);

	private Renderer _renderer; // All renderers inherit from Renderer.

	private void Awake()
	{
		color = false;
		_renderer = GetComponent<Renderer>();
		_renderer.material.color = _normalColor;
	}

	private void OnMouseDown()
	{
		if (color == false)
		{
			_renderer.material.color = _activeColor;
			color = true;
		}
		else
		{
			_renderer.material.color = _normalColor;
			color = false;
		}
	}

	public bool varColor()
	{
		return (color);
	}
}