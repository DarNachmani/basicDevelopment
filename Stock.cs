using System;

public class Stock
{
	public Tuple<int, double>[] inventory;
	public int countOfMasksSold;
	public double profit;

	public Stock(Tuple<int, double>[] arr)
	{
		this.inventory = arr;
		this.countOfMasksSold = 0;
		this.profit = 0;
	}

	public void Buy(int quantity, double price)
	{
		double tempQuantity = 0;
		for (int i = 0; i < this.inventory.Length; i++)
		{
			var mask = this.inventory[i];
			while (quantity > 0)
			{
				if (mask.Item1 >= quantity)
				{
					this.inventory[i] = Tuple.Create(mask.Item1 - quantity, mask.Item2);
					this.profit = quantity * price;
					this.countOfMasksSold += quantity;
					quantity = 0;
				}
				else
				{
					quantity -= mask.Item1;
					this.inventory[i] = Tuple.Create(0, mask.Item2);
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
		foreach (var mask in this.inventory)
		{
			while (quantity > 0)
			{
				if (mask.Item1 >= quantity)
				{
					cost = mask.Item2 * quantity + tempCost;
					profit = quantity * price + tempProfit;
					return profit - cost;
				}
				else
				{
					tempCost = mask.Item1 * mask.Item2;
					tempProfit = mask.Item1 * price;
					quantity -= mask.Item1;
				}
			}
			return profit - cost;
		}
		return profit - cost;
	}

	public int NumOfSold()
	{
		return this.countOfMasksSold;
	}

	public string ToString()
	{
		string finalString = "";
		for (int i = 0; i < 5; i++)
		{
			finalString += string.Format("From stock number {0} there are {1} masks", i + 1, this.inventory[i].Item1);
		}
		return finalString;
	}
}
