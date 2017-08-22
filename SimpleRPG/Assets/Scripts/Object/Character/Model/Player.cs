using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * プレイヤークラス
 */
public class Player : Character {
    [SerializeField] private int _hp;
    [SerializeField] private int _mp;
    [SerializeField] private int _atk;
    [SerializeField] private int _def;
    public int Hp
    {
        get { return this._hp; }
        set { this._hp = value; }
    }
    public int Mp
    {
        get { return this._mp; }
        set { this._mp = value; }
    }
    public int Atk
    {
        get { return this._atk; }
        set { this._atk = value; }
    }
    public int Def
    {
        get { return this._def; }
        set { this._def = value; }
    }

    private void Start()
    {
        this.Hp = _hp;
        this.Mp = _mp;
        this.Atk = _atk;
        this.Def = _def;
    }
}
