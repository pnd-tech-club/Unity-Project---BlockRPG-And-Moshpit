using UnityEngine;
using System.Collections;

/// <summary>
/// Creating instance of sounds from code with no effort
/// </summary>
public class SoundEffectsHelper : MonoBehaviour
{
	
	/// <summary>
	/// Singleton
	/// </summary>
	public static SoundEffectsHelper Instance;
	
	public AudioClip explosionSound;
	public AudioClip tripleSound;
	public AudioClip cameraSound;
	public AudioClip airhornSound;
	public AudioClip playerShotSound;
	public AudioClip smokeSound;
	public AudioClip findSound;
	public AudioClip noscopeSound;

	
	void Awake()
	{
		// Register the singleton
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of SoundEffectsHelper!");
		}
		Instance = this;
	}
	
	public void MakeExplosionSound()
	{
		MakeSound(explosionSound);
	}

	public void MakeTripleSound()
	{
		MakeSound(tripleSound);
	}

	public void MakeCameraSound()
	{
		MakeSound(cameraSound);
	}

	public void MakeAirhornSound()
	{
		MakeSound(airhornSound);
	}

	public void MakeSmokeSound()
	{
		MakeSound (smokeSound);
	}

	public void MakeFindSound()
	{
		MakeSound(findSound);
	}

	public void MakePlayerShotSound()
	{
		MakeSound(playerShotSound);
	}

	public void MakeNoscopeSound()
	{
		MakeSound(noscopeSound);
	}


	

	/// <summary>
	/// Play a given sound
	/// </summary>
	/// <param name="originalClip"></param>
	private void MakeSound(AudioClip originalClip)
	{
		// As it is not 3D audio clip, position doesn't matter.
		AudioSource.PlayClipAtPoint(originalClip, transform.position);
	}
}
