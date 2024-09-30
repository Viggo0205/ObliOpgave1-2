namespace ObligatoriskOpg1_2
{
    public class Trophy
    {
        public int Id { get; set; }
        public string Competition { get; set; }
        public int Year { get; set; }

        public Trophy() { }

        public override string ToString()
        {
            return $"Id: {Id}, Competition: {Competition}, Year: {Year}";
        }

        public void ValidateComp()
        {
            if (Competition == null || Competition.Trim().Length < 3)
            {
                throw new ArgumentOutOfRangeException("Competition navn skal være min 3 bogstaver langt");
            }
        }
        public void ValidateYear()
        {
            if (Year < 1970 || Year > 2024)
            {
                throw new ArgumentOutOfRangeException("Året skal ligge mellem 1970 og 2024");
            }
        }

        public void Validate()
        {
            ValidateYear();
            ValidateComp();
        }


    }
}
