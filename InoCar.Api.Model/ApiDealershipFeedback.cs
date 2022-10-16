﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoCar.Api.Model
{
    public class ApiDealershipFeedback
    {
        public int Id { get; set; }
        public int DealershipId { get; set; }

        public string FirstName { get; set; }

        public int PointNumber { get; set; }

        public string? Comment { get; set; }

        public DateTime PublicDate { get; set; }

    }
}
