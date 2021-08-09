using UnityEngine;
public class Enemy : IEnemy
{
    private int _countMoney;
    private int _countHeath;
    private int _countPower;
    private string _name;
    public Enemy(string name)
    {
        _name = name;
    }

    public void Update(DataPlayer dataPlayer, DataType dataType)
    {
        switch (dataType)
        {
            case DataType.Health:
                _countHeath = dataPlayer.Health;
                break;

            case DataType.Power:
                _countPower = dataPlayer.Power;
                break;

            case DataType.Money:
                _countMoney = dataPlayer.Money;
                break;
        }
        Debug.Log($"Update data {dataType}. Enemy:  {_name}");
    }

    public int Power
    {
        get
        {
            var power = _countPower + _countMoney - _countHeath;
            return power;
        }
    }
}
