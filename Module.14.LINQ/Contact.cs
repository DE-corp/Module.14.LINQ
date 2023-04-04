namespace Module._14.LINQ
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }

        public Contact(string firstName, string lastName, long phone, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
        }
    }
}
