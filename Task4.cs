using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace homeWork8
{
    struct Task4
    {
        public Person person = new Person();
        public Task4()
        {
            AddPerson();
        }
        public void SerializePerson(string Path)
        {
            Stream fStream = new FileStream(Path, FileMode.Create, FileAccess.Write);
            XElement elementPerson = new XElement("Person");
            XAttribute attrName = new XAttribute("name", this.person.FIO);
            elementPerson.Add(attrName);

            XElement elementAddress = new XElement("Address",
                                                    new XElement("Street",this.person.Street),
                                                    new XElement("HouseNumber",this.person.HouseNumber),
                                                    new XElement("FlatNumber",this.person.ApartmentNumber));
            XElement elementPhones = new XElement("Pfones",
                                                    new XElement("MobilePfone",this.person.MobilePfone),
                                                    new XElement("FlatPfone",this.person.HomePfoneNumber));
            elementPerson.Add(elementAddress, elementPhones);
            elementPerson.Save(fStream);

            //xmlSerializer.Serialize(fStream, this.person);
            fStream.Close();
        }
        private void AddPerson()
        {
            this.person = new Person(AddFIO(), AddStreet(), AddHouseNumber(), AddApartmentNumber(), AddMobilePfone(), AddHomePfoneNumber());
        }
        private string AddFIO()
        {
            Console.WriteLine("Введите ФИО пользователя:");
            string FIO = Console.ReadLine();
            return (FIO == string.Empty) ? "Иванов Иван Иванович" : FIO;
        }
        private string AddStreet()
        {
            Console.WriteLine("Введите название улицы:");
            string Street = Console.ReadLine();
            return (Street == string.Empty) ? "Ленина" : Street;
        }
        private int AddHouseNumber()
        {
            Console.WriteLine("Введите номер дома");
            try
            {
                int HouseNumber = int.Parse(Console.ReadLine());
                return HouseNumber;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        private int AddApartmentNumber()
        {
            Console.WriteLine("Введите номер квартиры");
            try
            {
                int ApartmentNumber = int.Parse(Console.ReadLine());
                return ApartmentNumber;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        private string AddMobilePfone()
        {
            Console.WriteLine("Введите номер сотового телефона:");
            string MobilePfone = Console.ReadLine();
            return (MobilePfone == string.Empty) ? "+7 999 999 99 99" : MobilePfone;
        }
        private string AddHomePfoneNumber()
        {
            Console.WriteLine("Введите номер домашнего телефона:");
            string HomePfoneNumber = Console.ReadLine();
            return (HomePfoneNumber == string.Empty) ? "+7 (999 99) 99-99-99" : HomePfoneNumber;
        }
    }
}
