using Godot;
using System;

public partial class App : Panel
{
	public int sum1 = 0;
	public int sum2 = 0;

	public int currentSum = 1;

	public string action = null;


	public void OnSpinBoxValueChanged(double newValue)
	{
		GD.Print(newValue);
		if (currentSum == 1)
		{
			sum1 = (int)Math.Round(newValue);
			sum2 = (int)Math.Round(newValue);
		}
		if (currentSum == 2)
		{
			sum2 = (int)Math.Round(newValue);
		}
	}

	public void OnAddButtonPressed()
	{
		GD.Print("Add");
		if (currentSum == 1)
		{
			action = "Add";
			currentSum = 2;
		}
	}

	public void OnSubtractButtonPressed()
	{
		GD.Print("Subtract");
		if (currentSum == 1)
		{
			action = "Subtract";
			currentSum = 2;
		}
	}

	public void OnMultiplyButtonPressed()
	{
		GD.Print("Multiply");
		if (currentSum == 1)
		{
			action = "Multiply";
			currentSum = 2;
		}
	}

	public void OnDivideButtonPressed()
	{
		GD.Print("Divide");
		if (currentSum == 1)
		{
			action = "Divide";
			currentSum = 2;
		}
	}

	public void OnEqualButtonPressed()
	{
		GD.Print("Equal");
		if (currentSum == 2)
		{
			GD.Print(action);
			GD.Print(sum1);
			GD.Print(sum2);
			if (action == "Add")
			{
				Print(sum1 + sum2);
			} 
			else if (action == "Subtract")
			{
				Print(sum1 - sum2);
			}
			else if (action == "Multiply")
			{
				Print(sum1 * sum2);
			}
			else if (action == "Divide")
			{
				Print(sum1 / sum2);
			}
		}
	}

	public void Print(int num)
	{
		currentSum = 1;
		sum1 = num;
		sum2 = num;
		GetNode<SpinBox>("SpinBox").Value = num;
		GD.Print(num);
		action = null;
	}
}
