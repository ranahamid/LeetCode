using System;
using System.Collections.Generic;
using System.IO;

namespace Notes_Solution
{
    public class Notes
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime CreatedOnUtc { get; set; }
    }
    public class NotesStore
    {
        List<Notes> notes;
        public NotesStore()
        {
            notes = new List<Notes>();
        }
        List<string> validStates = new List<string> { "completed", "active", "others" };
        public void AddNote(String state, String name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception(string.Format("Name cannot be empty"));
            }
            //if(string.IsNullOrEmpty(state) || ! validStates.Contains(state))
            if (string.IsNullOrEmpty(state) || !(state == "completed" || state == "active" || state == "others"))
            {
                throw new Exception(string.Format("Invalid state {0}", state));
            }
            notes.Add(new Notes
            {
                CreatedOnUtc = DateTime.UtcNow,
                Name = name,
                Status = state,
            });
        }
        public List<String> GetNotes(String state)
        {
            if (!(state == "completed" || state == "active" || state == "others"))
            {
                throw new Exception(string.Format("Invalid state {0}", state));
            }
            var list = notes.Where(x => x.Status == state).OrderBy(x => x.CreatedOnUtc).Select(x => x.Name).ToList();
            if (list.Any())
            {
                return list;
            }
            return new List<string>();
        }
    }

    public class Solution_Notes
    {
        // public static void Main()
        public static void Notes()
        {
            var notesStoreObj = new NotesStore();
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                var operationInfo = Console.ReadLine().Split(' ');
                try
                {
                    if (operationInfo[0] == "AddNote")
                        notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
                    else if (operationInfo[0] == "GetNotes")
                    {
                        var result = notesStoreObj.GetNotes(operationInfo[1]);
                        if (result.Count == 0)
                            Console.WriteLine("No Notes");
                        else
                            Console.WriteLine(string.Join(",", result));
                    }
                    else
                    {
                        Console.WriteLine("Invalid Parameter");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}