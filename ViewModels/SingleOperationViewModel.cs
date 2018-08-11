﻿using SensorFusion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorFusion.ViewModels
{
    public class SingleOperationViewModel
    {
		public long operationID { get; set; }
		public string hospitalName { get; set; }
		public string roomNO { get; set; }
		public DateTime date { get; set; }
		public Patient patient { get; set; }
		public List<Staff> staff { get; set; }



	}
}
