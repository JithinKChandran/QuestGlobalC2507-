namespace PhoneBook
{
    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public override string ToString() => ($"Name: {Name}, Phone: {Phone}");
    }
}
