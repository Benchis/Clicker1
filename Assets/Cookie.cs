using UnityEngine;

public class Cookie : MonoBehaviour
{
	public float shrinkSpeed;
	public Vector3 rotateSpeed;
	public GameManager manager;

	void Update()
	{
		// pop animation
		if (transform.localScale.x > 1f)
		{
			transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
		}

		transform.Rotate(rotateSpeed * Time.deltaTime);
	}

	void OnMouseDown()
	{
		transform.localScale = Vector3.one * 1.4f;
		manager.Clicks++;



	}
}