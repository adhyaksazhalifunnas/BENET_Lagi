using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BENET.Models
{
    public class SportModel
    {
        public int Id { get; set; }
        [Required]
        [DisplayName ("Sport Name")]
        public string SportName { get; set; }
        [Required]
        [DisplayName ("Type [Indoor/Outdoor]")]
        public string SportType { get; set; }
        [Required]
        [DisplayName("Drill")]
        public string SportDrill { get; set; }

        public SportModel()
        {
            Id = -1;
            SportName = "";
            SportType = "";
            SportDrill = "";
        }

        public SportModel(int id, string sportName, string sportType, string sportDrill)
        {
            Id = id;
            SportName = sportName;
            SportType = sportType;
            SportDrill = sportDrill;
        }
    }
    
}