namespace MicroOrmConsoleDemo
{
    [ServiceStack.DataAnnotations.Alias("Contacts")]
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return string.Format($"{Id} - {FirstName} {LastName} ({Title}) - {Company} ({Email})");
        }
    }
}