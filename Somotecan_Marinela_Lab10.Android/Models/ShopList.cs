﻿//using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;

//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using SQLite;



namespace Somotecan_Marinela_Lab10.Droid.Models
{
    public class ShopList

    {
        [PrimaryKey, AutoIncrement] 
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date
        { get; set; }
    }
}
