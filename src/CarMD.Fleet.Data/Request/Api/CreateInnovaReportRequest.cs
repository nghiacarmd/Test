﻿using CarMD.Fleet.Data.Dto;
using System;

namespace CarMD.Fleet.Data.Request.Api
{
    public class CreateInnovaReportRequest
    {
        public Guid UserId { get; set; }

        public long KioskId { get; set; }

        public VehicleInfo Vehicle { get; set; }

        public string MilDTC { get; set; }

        public int ToolMilStatus { get; set; }

        public string TimeZone { get; set; }

        public VehicleInnovaDataModel VehicleInnovaDataModel { get; set; }
    }
}
