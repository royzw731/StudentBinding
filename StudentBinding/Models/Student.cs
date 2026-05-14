using System;

namespace StudentBinding.Models
{
    public class Student : ObservableObject
    {
        private string name;
        private int age;
        private string image;
        private DateTime birthDate;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - BirthDate.Year;

                if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
                    age--;

                return age;
            }
        }

        public string Image
        {
            get { return image; }
            set
            {
                image = value;
                OnPropertyChanged();
            }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                birthDate = value;
                OnPropertyChanged();
            }
        }
        private string gender;

        public string Gender
        {
            get { return gender; }
            set
            {
                gender = value;
                OnPropertyChanged();
            }
        }
    }
}