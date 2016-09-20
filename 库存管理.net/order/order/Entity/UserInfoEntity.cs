using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order.Entity
{
    class UserInfoEntity
    {
        public static string userId{get;set;}
        public static string userName { get; set; }
        public static string userSex { get; set; }
        public static string userPhone { get; set; }
        public static string userAddress { get; set; }
        public static void reset()
        {
            userId = null;
            userName = null;
            userSex = null;
            userPhone = null;
            userAddress = null;
        }
 
    }
}
