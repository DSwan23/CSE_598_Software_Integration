﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public int SecretNumber(int lower, int upper)
	{
		DateTime currentDate = DateTime.Now;
		int seed = (int)currentDate.Ticks;
		Random random = new Random(seed);
		int sNumber = random.Next(lower, upper);
		return sNumber;
	}

	public string CheckNumber(int userNumber, int secretNumber)
	{
		if(userNumber == secretNumber)
		{
			return "Correct";
		}
		else
		{
			if(userNumber > secretNumber)
			{
				return "Too Big";
			}
			else
			{
				return "Too Small";
			}
		}
	}
}