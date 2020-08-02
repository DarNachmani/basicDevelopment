using System;

public class Stock
{
	public Tuple<int, int> [] inventory;
	public int countOfMasks, profit;

	public Stock(int countOfMasksSold)
	{
		this.inventory = new Tuple<int, int> [5];
		this.countOfMasksSold = countOfMasksSold;
		this.profit = 0;
	}

	public void Buy(int quantity, double price)
    {
		double tempQuantity = 0;
		foreach(var mask in this.inventory)
        {
			while(quantity > 0){
				if(mask.Item1 >= quantity)
				{
					mask.Item1 -= quantity;
					this.profit = quantity * price;
					this.countOfMasksSold += quantity;
					quantity = 0;
				}
				else{
					quantity -= mask.Item1;
					mask.Item1 = 0;
				}
			}
		}
		
    }

	public double Sell(int quantity, double price)
    {
		double tempCost = 0.0;
		double tempProfit = 0.0;
		foreach (var mask in this.inventory)
        {
			while(quantity > 0){
					if(mask[0] >= quantity)
				{
					double cost = mask.Item2 * quantity + tempCost;
					double profit = quantity * price + tempProfit;
					return profit - cost;
				}
				else
				{
					tempCost = mask.Item1 * mask.Item2;
					tempProfit = mask.Item1 * price;
					quantity -= mask.Item1;
				}
			}
        }
    }

	public int NumOfSold()
    {
		return this.countOfMasksSold;
    }

	public string ToString()
    {
		string finalString = "";
		for(int i=0; i<5; i++){
			finalString += string.Format("From stock number {0} there are {1} masks", i+1, this.inventory[i].Item1);
		}
		return finalString;
    }
}
