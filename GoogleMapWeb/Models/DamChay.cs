﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GoogleMapWeb.Models
{
    public class DamChay
    {
        public int id { get; set; }
        public int level { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string address { get; set; }
        public float damages { get; set; }
        public DateTime date { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }

        public DamChay(int id, int level, string city, string county, string address, float damages, DateTime date, float lat, float lng)
        {
            this.id = id;
            this.level = level;
            this.city = city;
            this.county = county;
            this.address = address;
            this.damages = damages;
            this.date = date;
            this.lat = lat;
            this.lng = lng;
        }
        public DamChay(DataRow row)
        {
            this.id = int.Parse(row["id"].ToString());
            this.level = int.Parse(row["level"].ToString());
            this.city = row["city"].ToString();
            this.county = row["county"].ToString();
            this.address = row["address"].ToString();
            this.damages = float.Parse(row["damages"].ToString());
            this.date = DateTime.Parse(row["date"].ToString());
            this.lat = float.Parse(row["lat"].ToString());
            this.lng = float.Parse(row["lng"].ToString());
        }
        public DamChay() { }
    }
}