using System;

public class Stock
{
	public List<Tuple<int, int>> inventory;
	public int countOfMasks, profit;

	public Stock(int countOfMasks)
	{
		this.inventory = new List<Tuple<int, int>>();
		this.countOfMasks = countOfMasks;
		this.profit = 0;
	}

	public void Buy(int quantity, double price)
    {
		foreach(var mask in this.inventory)
        {
			if(mask[1] == price)
            {
				mask[0] -= quantity;
				this.profit = quantity * price;
            }
		}
		
    }

	public double Sell(int quantity, double price)
    {
		double tempCost = 0.0;
		double tempProfit = 0.0;
		foreach (var mask in this.inventory)
        {
			if(mask[0] >= quantity)
            {
				double cost = mask[1] * quantity + tempCost;
				double profit = quantity * price + tempProfit;
				return profit - cost;
            }
            else
            {
				tempCost = mask[0] * mask[1];
				tempProfit = mask[0] * price;
				quantity -= mask[0];
            }
        }
    }
}
