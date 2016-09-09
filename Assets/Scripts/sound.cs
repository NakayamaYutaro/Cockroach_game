using UnityEngine;
using System.Collections;

public class sound : MonoBehaviour {

	private AudioSource gsound;

	void Start () {
		//AudioSourceコンポーネントを取得し、変数に格納
		gsound = GetComponent<AudioSource>();
	}

	void Update () {
		//指定のキーが押されたら音声ファイル再生
		if(Input.GetKeyDown(KeyCode.W)) {
			gsound.PlayOneShot(gsound.clip);
		}


	}
}
