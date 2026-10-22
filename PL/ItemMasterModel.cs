using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace HeroInspection.PL
{
    public class ItemMasterModel
    {
        public int iTbdID { get; set; }
        public string SiteCode { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        public string Encode { get; set; }
        public string CustomerCode { get; set; }

    }
}