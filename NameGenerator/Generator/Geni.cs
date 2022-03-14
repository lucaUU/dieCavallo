namespace Generator
{
    public class Geni
    {
        public string GenerateName(int size)
        {
            var availableChars = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string name = string.Empty;

            for(int i = 0; i < size; i++)
            {
                var random = new System.Random();
                var get = random.Next(0, maxValue: availableChars.Length - 1);

                name = name + availableChars[get];
            }

            return name;
        }
    }
}
