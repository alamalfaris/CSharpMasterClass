using System;
using System.Collections.Generic;
using System.IO;

namespace PasswordDecription
{
    class Program
    {
        static void Main(string[] args)
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

    public class NotesStore
    {
        public List<String> listNoteActive = new List<String>();
        public List<String> listNoteCompleted = new List<String>();
        public List<String> listNoteOthers = new List<String>();

        public NotesStore() { }
        public void AddNote(String state, String name)
        {
            if (name == null || name == "")
            {
                Console.WriteLine("Name cannot be empty");
            }

            if (state == "completed")
            {
                listNoteCompleted.Add(name);
            }
            else if (state == "active")
            {
                listNoteActive.Add(name);
            }
            else if (state == "others")
            {
                listNoteOthers.Add(name);
            }
            else
            {
                Console.WriteLine("Error: Invalid state {0}", state);
            }
        }
        public List<String> GetNotes(String state)
        {
            if (state != "completed" || state != "active" || state != "others")
            {
                Console.WriteLine("Error: Invalid state {0}", state);
            }

            if (state == "completed" && listNoteCompleted.Count > 0)
            {
                return listNoteCompleted;
            }
            else
            {
                return new List<String>();
            }

            if (state == "active" && listNoteActive.Count > 0)
            {
                return listNoteActive;
            }
            else
            {
                return new List<String>();
            }

            if (state == "others" && listNoteOthers.Count > 0)
            {
                return listNoteOthers;
            }
            else
            {
                return new List<String>();
            }
        }
    }
}
