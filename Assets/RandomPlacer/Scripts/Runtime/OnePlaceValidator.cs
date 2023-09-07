using UnityEngine;

namespace RandomPlacer
{
	[RequireComponent(typeof(Placer))]
	public class OnePlaceValidator : MonoBehaviour
	{
		[SerializeField] private Placer _placer;

		private void OnValidate()
		{
			_placer ??= GetComponent<Placer>();

			if (transform.childCount == 0)
				_placer.Place();
		}
	}
}
