using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _1242
    {
        public IList<string> Crawl(string startUrl, HtmlParser htmlParser)
        {
            var tasks = new HashSet<Task<IList<string>>>();
            var visited = new HashSet<string>();
            var url = new Uri(startUrl);


            tasks.Add(Task.Run(() => htmlParser.GetUrls(startUrl)));
            visited.Add(startUrl);

            while (tasks.Count > 0)
            {
                var completedTasks = Task.WhenAny(tasks).Result;
                tasks.Remove(completedTasks);
                foreach (var nextUrl in completedTasks.Result)
                {
                    if (!visited.Contains(nextUrl) && nextUrl.StartsWith($"http://{url.Host}"))
                    //if (nextUrl.StartsWith($"http://{url.Host}") && !visited.Contains(nextUrl))
                    {
                        tasks.Add(Task.Run(() => htmlParser.GetUrls(nextUrl)));
                        visited.Add(nextUrl);
                    }

                }
            }
            return visited.ToList();
        }
    }
}
