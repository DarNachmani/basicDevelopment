using System;

public class Stock
{
	private Tuple<int, double>[] _inventory;
	private int _countOfMasksSold;
	private double _profit;

	public Stock(Tuple<int, double>[] inventory)
	{
		_inventory = inventory;
		_countOfMasksSold = 0;
		_profit = 0;
	}

	public void Buy(int quantity, double price)
	{
		for (int i = 0; i < _inventory.Length; i++)
		{
			var maskInformation = _inventory[i];
			while (quantity > 0)
			{
				if (maskInformation.Item1 >= quantity)
				{
					_inventory[i] = Tuple.Create(maskInformation.Item1 - quantity, maskInformation.Item2);
					_profit = quantity * price;
					_countOfMasksSold += quantity;
					quantity = 0;
				}
				else
				{
					quantity -= maskInformation.Item1;
					_inventory[i] = Tuple.Create(0, maskInformation.Item2);
				}
			}
		}
	}

	public double Sell(int quantity, double price)
	{
		double tempCost = 0.0;
		double tempProfit = 0.0;
		double cost = 0;
		double profit = 0;
		foreach (var maskInformation in _inventory)
		{
			while (quantity > 0)
			{
				if (maskInformation.Item1 >= quantity)
				{
					cost = maskInformation.Item2 * quantity + tempCost;
					profit = quantity * price + tempProfit;
					return profit - cost;
				}
				else
				{
					tempCost = maskInformation.Item1 * maskInformation.Item2;
					tempProfit += maskInformation.Item1 * price;
					quantity -= maskInformation.Item1;
				}
			}
			return profit - cost;
		}
		return profit - cost;
	}

	public int NumOfSold()
	{
		return _countOfMasksSold;
	}

	public override string ToString()
	{
		string finalString = "";
		for (int i = 0; i < 5; i++)
		{
			finalString += $"From stock number {i + 1} there are {_inventory[i].Item1} masks{Environment.NewLine}";
		}
		return finalString;
	}
}
