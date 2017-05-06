﻿using GummyBears.DTO.Interfaces;

namespace GummyBears.DTO.Models
{
    public class StatsDB : IObjWithId
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int UserId { get; set; }
        public int EndMapState { get; set; }
        public int FinalGold { get; set; }
        public int FinalGummies { get; set; }
        public int OverallScore { get; set; }
    }
}