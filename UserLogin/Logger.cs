using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static public class Logger
    {
        static private List<string> currentSessionActivities = new List<string>();
        static public void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";"
                                + LoginValidation.userName + ";"
                                + LoginValidation.currentUserRole + ";"
                                + activity;
            currentSessionActivities.Add(activityLine);

            if (File.Exists("Logger.txt") == true)
            {
                File.AppendAllText("Logger.txt", activityLine);
            }
            else File.WriteAllText("Logger.txt", activityLine);
        }

        static public IEnumerable<string> GetCurrentActivities(string filter)
        {
            /*
            StringBuilder sb = new StringBuilder();
            foreach(string activity in currentSessionActivities)
            {
                sb.Append(activity);
            }
            Console.WriteLine(sb.ToString());
            */
            List<string> filteredActivity = (from activity in currentSessionActivities where activity.Contains(filter) select activity).ToList();
            return filteredActivity;
        }

        static public IEnumerable<string> GetLogActivities()
        {
            StreamReader reader = new StreamReader("Logger.txt");
            List<string> activityLine = new List<string>();
            activityLine.Add(reader.ReadLine());
            return activityLine;
        }
    }
}
