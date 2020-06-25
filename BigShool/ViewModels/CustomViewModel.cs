using BigShool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;


public class CustomViewModel : ValidationAttribute
{
  [Required]
    public string Place { get; set; }
    [Required]
    [FutureDate]
    public string Date { get; set; }
    [Required]
    public string Time { get; set; }

}