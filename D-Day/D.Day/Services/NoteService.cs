using D.Day.Models;
using D.Day.Repository;
using System;

namespace D.Day.Services
{
    public class NoteService
    {
        private readonly INoteRepository _noteRepository;

        public NoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public void CreateNote()
        {
            try
            {
                Console.Write("Enter note title: ");
                string title = Console.ReadLine();

                Console.Write("Enter note content: ");
                string content = Console.ReadLine();

                //if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(content))
                //{
                //    Console.WriteLine("Can't be empty.");
                //    return;
                //}

                Note note = new Note
                {
                    Title = title,
                    Content = content,
                    CreatedAt = DateTime.Now
                };

                _noteRepository.Create(note);
                Console.WriteLine("Note created.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        public void ViewNotes()
        {
            try
            {
                var notes = _noteRepository.GetAll();
                foreach (var note in notes)
                {
                    Console.WriteLine($"ID: {note.Id} | Title: {note.Title}| Created At: {note.CreatedAt} | Content: {note.Content}...");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        public void UpdateNote()
        {
            try
            {
                Console.Write("Enter note ID to update: ");
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    var note = _noteRepository.GetById(id);
                    if (note == null)
                    {
                        Console.WriteLine("Not found.");
                        return;
                    }

                    Console.WriteLine($"Title: {note.Title}");
                    Console.Write("New title | Enter to keep current: ");
                    string newTitle = Console.ReadLine();

                    Console.WriteLine($"Content: {note.Content}");
                    Console.Write("New Content | Enter to keep current: ");
                    string newContent = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(newTitle))
                    {
                        note.Title = note.Title;
                    }
                    else
                    {
                        note.Title = newTitle;
                    }

                    if (string.IsNullOrWhiteSpace(newContent))
                    {
                        note.Content = note.Content;
                    }
                    else
                    {
                        note.Content = newContent;
                    }
                    note.UpdatedAt = DateTime.Now;

                    _noteRepository.Update(note);
                    Console.WriteLine("Updated.");
                }
                else
                {
                    Console.WriteLine("Invalid ID.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        public void DeleteNote()
        {
            try
            {
                Console.Write("Enter note ID to delete: ");
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    var note = _noteRepository.GetById(id);
                    if (note == null)
                    {
                        Console.WriteLine("Not found.");
                        return;
                    }

                    Console.Write("Delete this note? (y/n): ");
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        _noteRepository.Delete(id);
                        Console.WriteLine("Deleted.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}

