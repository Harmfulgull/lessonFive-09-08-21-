using System.Collections.Generic;
public class DataPlayer 
{
    
    private string _titleData;

    private int _countHealth;
    private int _countMoney;
    private int _countPower;
    private List<IEnemy> _enemies = new List<IEnemy>();
    public DataPlayer(string titleData)
    {
        _titleData = titleData;
    }
    public string TitleData => _titleData;

    public int Health
    {
        get => _countHealth;
        set
        {
            if (_countHealth != value)
            {
                _countHealth = value;
                Notifier(DataType.Health);
            }
        }
    }
    public int Money
    {
        get => _countMoney;
        set
        {
            if (_countMoney != value)
            {
                _countMoney = value;
                Notifier(DataType.Money);
            }
        }
    }
    public int Power
    {
        get => _countPower;
        set
        {
            if (_countPower != value)
            {
                _countPower = value;
                Notifier(DataType.Power);
            }
        }
    }

    
    public void Attach(IEnemy enemy)
    {
        _enemies.Add(enemy);
    }

    public void Detach(IEnemy enemy)
    {
        _enemies.Remove(enemy);
    }

    private void Notifier(DataType dataType)
    {
        foreach (var enemy in _enemies)
        {
            enemy.Update(this, dataType);
        }
    }

}

class Money : DataPlayer
{
    public Money(string titleData) : base(titleData)
    {

    }
}
class Power : DataPlayer
{
    public Power(string titleData) : base(titleData)
    {

    }
}

class Health : DataPlayer
{
    public Health(string titleData) : base(titleData)
    {

    }
}

