using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebLtic.Commom
{
    [Serializable]
    public class UserLogin
    {
        public long UserID { get; set; } 
        public string UserName { get; set; }
    }
}