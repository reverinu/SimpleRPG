using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverGameManager : MonoBehaviour {

    public GameObject Player;
    public GameObject[] Ornaments;
    public GameObject Canvas;
    MessageWindowController MesWinController;
    

	// Use this for initialization
	void Awake () {
        // 初期化
        // オブジェクト配置
        // スタートするものはスタートさせておく
        Instantiate(Player);
        for ( int i = 0; i < Ornaments.Length; i++ ) {
            Instantiate(Ornaments[i]);
        }
        MesWinController = Canvas.GetComponent<MessageWindowController>();
        MesWinController.StartMessageWindow("aaaaaaaaaaaa\\wwwwwwwwwwww");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
