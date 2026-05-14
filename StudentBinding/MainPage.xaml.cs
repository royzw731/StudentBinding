using System.ComponentModel;
using System.Runtime.CompilerServices;
using StudentBinding.Models;

namespace StudentBinding
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        Student student1;
        Student student2;

        private Student shownStudent;

        public Student ShownStudent
        {
            get { return shownStudent; }
            set
            {
                shownStudent = value;
                OnPropertyChanged();
            }
        }

        public MainPage()
        {
            InitializeComponent();

            student1 = new Student
            {
                Name = "דניאל",
                Gender = "זכר",
                Image = "daniel.png",
                BirthDate = new DateTime(2009, 4, 12)
            };

            student2 = new Student
            {
                Name = "נועה",
                Gender = "נקבה",
                Image = "noa.png",
                BirthDate = new DateTime(2010, 9, 25)
            };

            ShownStudent = student1;

            BindingContext = this;
        }

        public new event PropertyChangedEventHandler PropertyChanged;

        protected new void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (ShownStudent == student1)
                ShownStudent = student2;
            else
                ShownStudent = student1;
        }
    }
}