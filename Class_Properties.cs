using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplication4
{
    public static class Class_Properties
    {

        # region Masters
        // for USER
        public class User
        {
            public string TASK { get; set; }
            public string SEARCH_VALUE { get; set; }
            public string ID { get; set; }
            public string USER_NAME { get; set; }
            public string NAME { get; set; }
            public string PASSWORD { get; set; }
            public string ADDRESS { get; set; }
            public string MOBILE_NO { get; set; }          
            public string CREATED_BY { get; set; }
            public string ISDELETED { get; set; }
        }
        

        #endregion

    }
}
