using UnityEngine;

public class CameraControlla : MonoBehaviour {
	[SerializeField] private float _xMax;
	[SerializeField] private float _yMax;
	[SerializeField] private float _xMin;
	[SerializeField] private float _yMin;
	[SerializeField] private Transform _target;

	private void Update ()
	{
		transform.position = new Vector3 (Mathf.Clamp(_target.position.x,_xMin,_xMax), Mathf.Clamp(_target.position.y,_yMin,_yMax), transform.position.z);
	}
}
