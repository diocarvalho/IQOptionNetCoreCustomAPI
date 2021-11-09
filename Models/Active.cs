﻿using System;
using IqApiNetCore.Models;

namespace IqApiNetCore.Models
{
    //Receive Active Data
    public class Active
    {
        public string name { get; set; }
        public int group_id { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public decimal minimal_bet { get; set; }
        public decimal maximal_bet { get; set; }
        public bool top_traders_enabled { get; set; }
        public int id { get; set; }
        public int precision { get; set; }
        public Option option { get; set; }
        public bool enabled { get; set; }
        public int deadtime { get; set; }
        public int start_time { get; set; }
        public string provider { get; set; }
        public int is_buyback { get; set; }
        public int buyback_deadtime { get; set; }
        public bool rollover_enabled { get; set; }
        public int rollover_commission { get; set; }
        public Schedule[] Schedules { get; set; }
        public DateTime close_at { get; set; }

    }
}
