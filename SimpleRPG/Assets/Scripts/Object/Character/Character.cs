using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * キャラクタークラス
 */
public class Character : ReverObject {

    /* 年齢 */
    [SerializeField] private int _age;
    public int Age {
        get { return this._age; }
        protected set { this._age = value; }
    }

    private void Start()
    {
        this.Age = _age;
    }
}