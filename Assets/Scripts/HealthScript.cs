using UnityEngine;
public class HealthScript : MonoBehaviour
{
	public Transform hitmarkPrefab;
	public int scoreValue;
	private GameController gameController;
	public int hp = 1;
	public bool isEnemy = true;
	public GameObject Hitmarker;

	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	}
	public void Damage(int damageCount)
	{
		hp -= damageCount;

		if (hp <= 0)
		{
			var hitmarkTransform = Instantiate(hitmarkPrefab) as Transform;
			hitmarkTransform.position = transform.position;

			Destroy(gameObject);
			Destroy(Hitmarker.gameObject);
			SoundEffectsHelper.Instance.MakeExplosionSound();
			SoundEffectsHelper.Instance.MakeNoscopeSound();
			gameController.AddScore (scoreValue);

		}
	}

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
		if (shot != null)
		{
			if (shot.isEnemyShot != isEnemy)
			{
				Damage(shot.damage);
				Destroy(shot.gameObject); 
			}
		}
	}
}
