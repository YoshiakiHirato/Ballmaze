using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour {

	public void Onclick (int i)
	{
		SceneManager.LoadScene (i);
	}

}
