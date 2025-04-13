using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Json
{
    public class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n1.Qruplara bax\n2.Qrup yarat\n3.Qrupu sil\n4.Qrupa kec");
                Console.WriteLine("Choice:  ");
                string choice=Console.ReadLine();
                switch (choice) 
                {
                    case "1": ShowGrups();break;
                    case "2": CreateGroup();break;
                    case "3": RemoveGroup();break;
                    case "4": EnterGroup();break;
                    default: Console.WriteLine("yanlis  secim: ");break;

                }
            }
        }
        public void ShowGroups() 
        {
            foreach (var group in Groups)
                Console.WriteLine($"{group.Name}");
        }
        public void CreateGroup() 
        {
            Console.WriteLine("Qrup adi:");
            string name = Console.ReadLine();
            Groups.Add(name,name);
            Console.WriteLine("qrup yaradildi");
        }
        public void RemoveGroup()
        {
            Console.WriteLine("silinecek qrupun adi: ");
            string name=Console.ReadLine();
            Groups.Remove(name, name);
            Console.WriteLine("qrup silindi:");
        }
        public void EnterGroup() 
        {
            Console.WriteLine("qrupun adi: ");
            string name= Console.ReadLine();
        }
    }
}
