using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CourseWork2.Model;

namespace CourseWork2.ViewModel
{
   public class ViewModelRes: INotifyPropertyChanged
    {
        private string FirstName;
        private string SecondName;
        private string PatronymicResident;
        private string InformationAboutResident;
        private int AgeResident;
        private int RoomNumber;
        private bool SexResident;
       
       

        public event PropertyChangedEventHandler PropertyChanged;

       
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
       

        public string Firstname
        {
            get { return FirstName; }
            set { FirstName = value; OnPropertyChanged("FirstName"); }
        }

        public string Secondname
        {
            get { return SecondName; }
            set { SecondName = value; OnPropertyChanged("SecondName"); }

        }

        public string Patronymicresident
        {
            get { return PatronymicResident; }
            set { PatronymicResident = value; OnPropertyChanged("PatronymicResident"); }
        }

        public string Infomation
        {
            get { return InformationAboutResident; }
            set { InformationAboutResident = value; OnPropertyChanged("InformationAboutResident"); }
        }

        public int Ageresident
        {
            get { return AgeResident; }
            set { AgeResident = value; OnPropertyChanged("AgeResident"); }
        }

        public int Roomnumber
        {
            get { return RoomNumber; }
            set { RoomNumber = value; OnPropertyChanged("RoomNumber"); }
        }

        public bool Sexresident
        {
            get { return SexResident; }
            set { SexResident = value; OnPropertyChanged("SexResident"); }
        }


   }

         
}
