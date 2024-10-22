namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new ContactManager();

            manager.AddContact(
            new Contact
            {
                Name = "Test",
                Phone = "123456"
            });

            manager.UpdateContact("Test", "321654");
            manager.DeleteContact("Test");
            manager.SearchContact("321654");
        }
    }
}
