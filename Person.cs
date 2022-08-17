using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork8
{
    public class Person
    {
        public string FIO { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int ApartmentNumber { get; set; }
        public string MobilePfone { get; set; }
        public string HomePfoneNumber { get; set; }
        /// <summary>
        /// Констурктор структуры Person
        /// </summary>
        /// <param name="FIO">ФИО пользователя</param>
        /// <param name="Street">Улица</param>
        /// <param name="HouseNumber">Номер дома</param>
        /// <param name="ApartmentNumber">Номер квартиры</param>
        /// <param name="MobilePfone">Номер мобильного телефона</param>
        /// <param name="HomePfoneNumber">Номер домашнего телефона</param>
        public Person()
        { }
        public Person(string FIO,string Street,int HouseNumber,int ApartmentNumber,string MobilePfone,string HomePfoneNumber)
        {
            this.FIO = FIO;
            this.Street = Street;
            this.HouseNumber = HouseNumber;
            this.ApartmentNumber = ApartmentNumber;
            this.MobilePfone = MobilePfone; 
            this.HomePfoneNumber = HomePfoneNumber;
        }

    }
}
