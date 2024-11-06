using D.Day.Models;
using D.Day.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace NoteTakingApp.Repositories
{
    public class JsonNoteRepository : INoteRepository
    {
        private readonly string _storageDirectory;

        public JsonNoteRepository()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _storageDirectory = Path.Combine(documentsPath, "NoteApp", "JsonData");
            Directory.CreateDirectory(_storageDirectory);
        }

        public void Create(Note note)
        {
            try
            {
                note.Id = GenerateUniqueId();
                var notes = GetAll();
                notes.Add(note);
                SaveNotes(notes);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        public List<Note> GetAll()
        {
            var filePath = Path.Combine(_storageDirectory, "notes.json");
            if (!File.Exists(filePath))
            {
                return new List<Note>();
            }

            try
            {
                var json = File.ReadAllText(filePath);
                var notes = JsonConvert.DeserializeObject<List<Note>>(json);
                if (notes == null)
                {
                    notes = new List<Note>();
                }
                return notes;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return new List<Note>();
            }
        }

        public Note GetById(int id)
        {
            try
            {
                var notes = GetAll();
                return notes.Find(note => note.Id == id);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return null;
            }
        }

        public void Update(Note note)
        {
            try
            {
                var notes = GetAll();
                var index = notes.FindIndex(n => n.Id == note.Id);
                if (index == -1)
                {
                    Console.WriteLine("Note not found.");
                    return;
                }

                notes[index] = note;
                SaveNotes(notes);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                var notes = GetAll();
                var note = notes.Find(n => n.Id == id);
                if (note == null)
                {
                    Console.WriteLine("Note not found.");
                    return;
                }

                notes.Remove(note);
                SaveNotes(notes);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        private int GenerateUniqueId()
        {
            var notes = GetAll();
            int maxId = 0;
            foreach (var n in notes)
            {
                if (n.Id > maxId)
                {
                    maxId = n.Id;
                }
            }
            return maxId + 1;
        }

        private void SaveNotes(List<Note> notes)
        {
            try
            {
                var filePath = Path.Combine(_storageDirectory, "notes.json");
                var json = JsonConvert.SerializeObject(notes, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
