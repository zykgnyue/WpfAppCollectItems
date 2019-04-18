using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfAppCollectItems
{
    public class NameConverter : IMultiValueConverter

    {

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)

        {

            string name;
            switch ((string)parameter)
            {

                case "FormatLastFirst":
                    name = values[1] + ", " + values[0];
                    break;
                case "FormatNormal":
                    name = values[0] + " " + values[1];
                    break;
                default:
                    //convert string to listbox parameter=null
                    name = values[0] + " " + values[1] + " Email:" + values[2];
                    break;

            }



            return name;

        }



        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)

        {

            var splitValues = ((string)value).Split(' ');

            return splitValues;

        }

    }
    public class NameList : ObservableCollection<PersonName>
    {
        public NameList() : base()
        {
            Add(new PersonName("Willa", "Cather"));
            Add(new PersonName("Isak", "Dinesen"));
            Add(new PersonName("Victor", "Hugo"));
            Add(new PersonName("Jules", "Verne"));
            Add(new PersonName("Wang", "Lina"));
            Add(new PersonName("Mei", "Daoheng"));
        }
    }

    public class PersonName
    {
        private string firstName;
        private string lastName;
        private static int count=0;
        public PersonName(string first, string last,string email="foo1{0}@tju.edu.cn")
        {
            this.firstName = first;
            this.lastName = last;
            count++;
            this.EmailAddress = string.Format(email,count);
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string EmailAddress { get;set; }
    }
}
