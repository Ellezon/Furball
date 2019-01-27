using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SpriteRenderer))]
public class WrapAround : MonoBehaviour 
{
	public bool wrapWidth = true;
	public bool wrapHeight = true;

	private Renderer _renderer;
	private Transform _transform;
	private Camera _camera;
	private Vector2 _viewportPosition;
	private bool isWrappingWidth;
	private bool isWrappingHeight;
	private Vector2 _newPosition;

	// Use this for initialization
	void Start () 
	{
		_renderer = GetComponent<Renderer> ();
		_transform = transform;
		_camera = Camera.main;
		_viewportPosition = Vector2.zero;
		isWrappingWidth = false;
		isWrappingHeight = false;
		_newPosition = _transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		Wrap ();
	}

	private void Wrap()
	{
		bool isVisible = IsBeingRendered ();

		if (isVisible) 
		{
			isWrappingWidth = false;
			isWrappingHeight = false;
		}

		_newPosition = _transform.position;
		_viewportPosition = _camera.WorldToViewportPoint (_newPosition);

		if (wrapWidth) 
		{
			if (!isWrappingWidth) 
			{
				if(_viewportPosition.x > 1)
				{
					_newPosition.x = _camera.ViewportToWorldPoint (Vector2.zero).x;
					isWrappingWidth = true;
				}
				else if(_viewportPosition.x < -0.1)
				{
					_newPosition.x = -_camera.ViewportToWorldPoint (Vector2.zero).x;
					isWrappingWidth = true;
				}
			}
		}

		if (wrapHeight) 
		{
			if (!isWrappingHeight) 
			{
				if(_viewportPosition.y > 1)
				{
					_newPosition.y = _camera.ViewportToWorldPoint (Vector2.zero).y;
					isWrappingHeight = true;
				}
				else if(_viewportPosition.y < -0.1)
				{
					_newPosition.y = -_camera.ViewportToWorldPoint (Vector2.zero).y;
					isWrappingHeight = true;
				}
			}
		}
		_transform.position = _newPosition;
	}

	private bool IsBeingRendered()
	{
		if (_renderer.isVisible) 
		{
			return true;
		}
		return false;
	}
}