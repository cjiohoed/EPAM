using System;

namespace Task2
{
    public class Person
    {
        public string Name { get; set; }
        public bool IsCame { get; set; } = false;
        private int time;

        public event EventHandler Came;
        public event EventHandler Leave;

        public Person(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Value cannot be null or empty.", nameof(name));
            }
                
            Name = name;
        }

        public void Hello(Person person, DateTime time)
        {
            var prefix = String.Empty;

            if (time.Hour < 12)
            {
                prefix = "Доброе утро";
            }
            else if (time.Hour >= 12 && time.Hour < 17)
            {
                prefix = "Добрый день";
            }
            else if (time.Hour >= 17)
            {
                prefix = "Добрый вечер";
            }

            Console.WriteLine($"\"{prefix} {person.Name}!\" - сказал {Name}.");
        }

        public void Bye(Person person)
        {
            Console.WriteLine($"\"До свидания, {person.Name}!\" - сказал {Name}.");
        }

        public void OnCame()
        {
            Came?.Invoke(this, EventArgs.Empty);
        }

        public void OnLeave()
        {
            Leave?.Invoke(this, EventArgs.Empty);
        }
    }
}
