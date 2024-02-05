using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR2_Baymurzaev.Models
{
    public partial class Task
    {
        public string UsersInfo
        {
            get
            {
                string info = "";
                foreach (var task in TaskUser)
                {
                    info += $"{task.User.FIO}: {task.Starus}\n";
                }
                return info;
            }
        }
        public string PlatformsInfo
        {
            get
            {
                string info = "";
                foreach (var task in TaskPlatforms)
                {
                    info += $"{task.Platforms.Title}\n";
                }
                return info;
            }
        }
    }
}
