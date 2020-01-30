using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Database
{
    class ConnectionString
    {
        public string getCreateString()
        {
            return
                "SERVER=\"localhost\";"
                + "DATABASE=\"test\";"
                + "UID=\"root\";"
                + "PASSWORD=\"\";"
                + "PORT=\"3306\";";
        }
        public string getConnectionString()
        {
            return
                "SERVER=\"localhost\";"
                + "DATABASE=\"buildyourbody\";"
                + "UID=\"root\";"
                + "PASSWORD=\"\";"
                + "PORT=\"3306\";";
        }
    }
}
