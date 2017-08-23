using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReverGameManager : MonoBehaviour {

    public GameObject Player;
    public GameObject[] Ornaments;
    public GameObject Canvas;
    private MessageWindowController MesWinController;
    private ReverCollisionChecker CollisionChecker;
    

	// Use this for initialization
	void Awake () {
        // 初期化
        // オブジェクト配置
        // スタートするものはスタートさせておく
        Instantiate( Player );
        for ( int i = 0; i < Ornaments.Length; i++ ) {
            Instantiate( Ornaments[i], Ornaments[i].GetComponent<Ornament>().Position, Quaternion.identity );
        }
        MesWinController = Canvas.GetComponent<MessageWindowController>();
        CollisionChecker = GameObject.FindWithTag("Player").GetComponent<ReverCollisionChecker>();
	}
	
	// Update is called once per frame
	void Update () {
        if ( CollisionChecker.IsCollisionOrnament ) {
            if ( Input.GetKeyDown( KeyCode.Space ) && !MesWinController.IsMessageLoop ) {
                MesWinController.StartMessageWindow( CollisionChecker.CollisionOrnament.Message );
            }
        }
	}

    
}
