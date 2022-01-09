using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using COMS201_LAB10.Models;

namespace COMS201_LAB10.Controllers
{
    public class HomeController : Controller
    {

        private static readonly List<Race> races = new List<Race> { };
        // This method is provided for you.
        // It adds two sample Race objects to the races List if the list is empty.
        private static void AddSampleRaces()
        {
            if (races.Count < 1)
            {
                races.Add(new Race("Dallas Marathon", "2020-11-30 08:00", 0));
                races.Add(new Race("Juniper 500", "2020-12-17 11:00", 1));
            }
        }
        
        public IActionResult Index()
        {
            AddSampleRaces();
            if (Request.ContentLength.HasValue)
            {
                // The Request.Form collection contains all the data from the webpage
                string race_name = Request.Form["txtRaceName"];
                string race_date = Request.Form["txtRaceDate"];
                string race_type = Request.Form["optRaceType"];

                races.Add(new Race(race_name, race_date, Convert.ToInt32(race_type)));

               
            }
            return View(races);
        }
    }
}
