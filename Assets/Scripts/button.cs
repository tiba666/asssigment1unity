using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public string name;
	public Vector3 position;
	public GameObject player;
    public void prnitString()
    {
        print(name);
    }
	public void playSound()
	{
		GetComponent<AudioSource>().Play();
	}
	public void spawnPlayer()
	{
		if (player != null)
		{
			Instantiate(player, position, Quaternion.identity);
		}
	}
}
