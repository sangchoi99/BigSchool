﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigShool.ViewModels
{
	public class FutureDate
	{
          public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "dd/MM/yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);
            return (isValid && dateTime > DateTime.Now);
        }
    }
}