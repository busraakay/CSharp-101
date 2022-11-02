using System;
using System.Collections.Generic;
using System.Linq;

namespace proje_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory directory = new Directory();
            string choice = "";
            
            do
            {
                
            
                Console.WriteLine("Lutfen yapmak istediginiz islemi seciniz :)");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayi Silmek");
                Console.WriteLine("(3) Varolan Numarayi Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                Console.WriteLine("(6) Cikis");
                Console.Write("Secim : ");

                choice = Console.ReadLine();
                                
                switch (choice)
                {
                    case "1":
                        Console.Write("Lutfen isim giriniz            : ");
                        string name = Console.ReadLine();
                        Console.Write("Lutfen soyisim giriniz         : ");
                        string surname = Console.ReadLine();
                        Console.Write("Lutfen telefon numarasi giriniz: ");
                        string no = Console.ReadLine();

                        var contact = new Contact(name, surname, no);
                        directory.NewContact(contact);
                        Console.WriteLine("Kisi Eklendi!");
                        directory.ContactList();
                        break;
                    case "2":
                        string choiceRemove = "";
                        do
                        {
                            Console.Write("Lutfen silmek istediginiz ismi veya soyismi giriniz: ");
                        string contactRemove = Console.ReadLine();
                        if(!directory.IsContainsName(contactRemove)){
                            Console.WriteLine("Aradiginiz kriterlere uygun kisi bulunamadi. Lutfen bir secim yapiniz: ");
                            Console.WriteLine("*Silmeyi sonlandirmak icin : (1)");
                            Console.WriteLine("*Yeniden denemek icin      : (2)");
                            choiceRemove = Console.ReadLine();
                            if(choiceRemove == "2"){
                                continue;
                            }
                        }
                        else{
                            Console.WriteLine(contactRemove + " kisisini silmeyi onaylıyor musunuz? (y/n)");
                            string yOrN = Console.ReadLine();
                            if(yOrN == "y"){
                                directory.ContactRemoveFromName(contactRemove);
                                Console.WriteLine("Kisi silindi!");
                                choiceRemove = "1";
                                
                            }
                            if(yOrN == "n"){
                                Console.WriteLine("Kisi silinmedi.");
                                choiceRemove = "1";
                            }
                        }
                        } while (choiceRemove != "1");
                        
                        directory.ContactList();
                        break;
                    case "3":
                        string choiceUpdate = "";
                        do
                        {
                            Console.WriteLine("Lutfen numarasini guncellemek istediginiz kisinin numarasini giriniz: ");
                        string contactUpdate = Console.ReadLine();
                        if(!directory.IsContainsNumber(contactUpdate)){
                            Console.WriteLine("Aradiginiz kriterlere uygun veri bulunamadi. Lutfen bir secim yapiniz: ");
                            Console.WriteLine("*Guncellemeyi sonlandirmak icin : (1)");
                            Console.WriteLine("*Yeniden denemek icin      : (2)");
                            choiceUpdate = Console.ReadLine();
                            if(choiceUpdate == "2"){
                                continue;
                            }
                        }
                        else{
                            Console.WriteLine("Numarayi guncelleyiniz: ");
                            string newNumber = Console.ReadLine();
                            directory.ContactUpdateNumber(contactUpdate, newNumber);
                            choiceUpdate = "1";
                        }
                        } while (choiceUpdate != "1");
                        break;  
                    case "4":
                        directory.ContactList();
                        break;
                    case "5":
                        string choiceFind = "";
                        Console.WriteLine("Aramak yapmak istediginiz tipi seciniz: ");
                        Console.WriteLine("****************************************");  
                        Console.WriteLine("Isim veya soyisime gore arama yapmak icin: (1)");
                        Console.WriteLine("Telefon numarasina gore arama yapmak icin: (2)");
                        choiceFind = Console.ReadLine();
                        string search = "";

                        if (choiceFind == "1")
                        {
                            Console.WriteLine("Aranan ismi veya soyismi giriniz: ");
                            search = Console.ReadLine();
                            directory.ContactSearchFromName(search);
                            
                        }
                        if (choiceFind == "2")
                        {
                            Console.WriteLine("Aranan numarayi giriniz: ");
                            search = Console.ReadLine();
                            directory.ContactSearchFromNumber(search);
                        }
                        break;
                    case "6":
                        Console.WriteLine("Cikis yapiliyor..");
                        break;

                    default:
                        Console.WriteLine("Yanlis deger girdiniz. Tekrar deneyiniz:");
                        break;

                }
            } while (choice != "6");

        }
    }
    
    class Directory{
        public List<Contact> contacts = new List<Contact>();

        public void NewContact(Contact contact){
            contacts.Add(contact);
        }

        public void ContactList(){
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("***********************************");
            foreach (var item in contacts)
            {
                Console.WriteLine("Isim: " + item.Name);
                Console.WriteLine("Soyisim: " + item.Surname);
                Console.WriteLine("Telefon numarasi: " + item.No);
                Console.WriteLine("-");
            }
        }

        public bool IsContainsName(string contactName){
            return contacts.Any(x => x.Name == contactName || x.Surname == contactName);
        }

        public bool IsContainsNumber(string number){
            return contacts.Any(x => x.No == number);
        }

        public void ContactRemoveFromName(string contactName){
            var contact = contacts.Find(x => (x.Name == contactName) || (x.Surname == contactName));
            contacts.Remove(contact);
        }

        public void ContactUpdateNumber(string number, string newNumber){
            foreach (var contact in contacts.Where(x => x.No == number).Take(1)) {
            contact.No = newNumber;
            }  
        }

        public void ContactSearchFromNumber(string number){
            Console.WriteLine("Arama Sonuclariniz:");
            Console.WriteLine("***********************************");
            foreach (var item in contacts.Where(x => x.No == number))
            {
                Console.WriteLine("Isim: " + item.Name);
                Console.WriteLine("Soyisim: " + item.Surname);
                Console.WriteLine("Telefon numarasi: " + item.No);
                Console.WriteLine("-");
            }
        }

        public void ContactSearchFromName(string name){
            Console.WriteLine("Arama Sonuclariniz:");
            Console.WriteLine("***********************************");
            foreach (var item in contacts.Where(x => x.Name == name || x.Surname == name ))
            {
                Console.WriteLine("Isim: " + item.Name);
                Console.WriteLine("Soyisim: " + item.Surname);
                Console.WriteLine("Telefon numarasi: " + item.No);
                Console.WriteLine("-");
            }
        }
        
    }

    class Contact{
        private string name;
        private string surname;
        private string no;

        public string Name { 
            get => name; 
            set => name = value; 
        }
        public string Surname { get => surname; set => surname = value; }
        public string No { get => no; set => no = value; }

        public Contact(string name, string surname, string no){
            this.Name = name;
            this.Surname = surname;
            this.No = no;
        }
    }
}
