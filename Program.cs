using System.Security.Cryptography.X509Certificates;
using wypozyczalnia;
List<Client> clientList = new List<Client>();

clientList.Add(new Client { Id = 1, Name = "Jan Nowak", DrivingLicenseDate = new DateTime(2021, 4, 3) });
clientList.Add(new Client { Id = 2, Name = "Agnieszka Kowalska", DrivingLicenseDate = new DateTime(1999, 1, 15) });
clientList.Add(new Client { Id = 3, Name = "Robert Lewandowski", DrivingLicenseDate = new DateTime(2010, 12, 18) });
clientList.Add(new Client { Id = 4, Name = "Zofia Płucińska", DrivingLicenseDate = new DateTime(2020, 4, 29) });
clientList.Add(new Client { Id = 5, Name = "Grzegorz Braun", DrivingLicenseDate = new DateTime(2015, 7, 12) });

List<Car> carList = new List<Car>();
carList.Add(new Car { Id = 1, Brand = "Skoda Citigo", Type = "mini", Engine = "Benzyna", Status = true, Price = 70 });
carList.Add(new Car { Id = 2, Brand = "Toyota Aygo", Type = "mini", Engine = "Benzyna", Status = true, Price = 90 });
carList.Add(new Car { Id = 3, Brand = "Fiat 500", Type = "mini", Engine = "elektryczny", Status = true, Price = 110 });
carList.Add(new Car { Id = 4, Brand = "Ford Focus", Type = "kompakt", Engine = "diesel", Status = true, Price = 160 });
carList.Add(new Car { Id = 5, Brand = "Kia Ceed", Type = "kompakt", Engine = "benzyna", Status = true, Price = 150 });
carList.Add(new Car { Id = 6, Brand = "Volkswagen Golf", Type = "kompakt", Engine = "benzyna", Status = true, Price = 160 });
carList.Add(new Car { Id = 7, Brand = "Hyundai Kona Electric", Type = "kompakt", Engine = "elektryczny", Status = true, Price = 180 });
carList.Add(new Car { Id = 8, Brand = "Audi A6 Allroad", Type = "premium", Engine = "diesel", Status = true, Price = 290 });
carList.Add(new Car { Id = 9, Brand = "Mercedes E270 AMG", Type = "premium", Engine = "benzyna", Status = true, Price = 320 });
carList.Add(new Car { Id = 10, Brand = "Tesla Model S", Type = "premium", Engine = "elektryczny", Status = true, Price = 350 });
Console.WriteLine("Witamy w aplikacji wypożyczania samochodu");
Console.WriteLine("Co chcesz zrobić?");
Console.WriteLine("1 => Lista klientów i samochodów");
Console.WriteLine("2 => Wypożycz samochód");
Console.WriteLine("3 => Zamknij program");
int userinput = Convert.ToInt32(Console.ReadLine());
if (userinput == 1)
{
    Console.WriteLine("Lista Klientów");
    foreach (var client in clientList)
    {
        Console.WriteLine($"{client.Id} - {client.Name} - {client.DrivingLicenseDate.ToShortDateString()}");
    }
    Console.WriteLine("Lista samochodów");
    foreach (var car in carList)
    {
        Console.WriteLine($"ID Samochodu:{car.Id} - Marka Samochodu: {car.Brand} - Segment:{car.Type} - Silnik: {car.Engine} - Czy dostępny? {car.Status} - Cena za dzień: {car.Price}PLN");
    }

}
else if (userinput == 2)
{


    Console.WriteLine("Wypożyczenie samochodu");
    Console.WriteLine("Podaj ID Klienta (1-5)");
    int idklienta = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Podaj preferencje klienta");
    Console.WriteLine("Segment samochodu: mini, kompakt, premium");
    string segment = Console.ReadLine();
    Console.WriteLine("Podaj rodzaj paliwa: benzyna, diesel, elektryczny");
    string fuel = Console.ReadLine();
    Console.WriteLine("Podaj ilość dni wypożyczenia");
    int okresWypozyczenia = Convert.ToInt32(Console.ReadLine());
    bool carfound = false;
    foreach (var car in carList)
    {
        if (car.Type == segment && car.Engine == fuel && car.Status)
        {
            int DrivingLicenseYears = DateTime.Now.Year - clientList.Find(x => x.Id == idklienta).DrivingLicenseDate.Year;
            decimal LessThen4years = 1m;
            if (DrivingLicenseYears < 4) { LessThen4years = 1.2m; }
            if (DrivingLicenseYears < 4 && segment == "premium")
            {
                Console.WriteLine("Ten użytkownik nie może wypożyczyć tego samochodu (zbyt krótko posiada prawo jazdy)");
                break;

            }
            if (okresWypozyczenia > 7 && okresWypozyczenia < 30) { _ = okresWypozyczenia - 1; }
            if (okresWypozyczenia >= 30) { _ = okresWypozyczenia - 3; }
            carfound = true;
            car.Status = false;
            Console.WriteLine("Wypożyczono samochód");
            Console.WriteLine($"Data wypożyczenia: {DateTime.Now.ToShortTimeString()}");
            Console.WriteLine($"Imię i nazwisko klienta: {clientList.Find(k => k.Id == idklienta).Name}");
            Console.WriteLine($"Data zwrotu pojazdu: {DateTime.Now.AddDays(okresWypozyczenia).ToShortDateString()}");
            Console.WriteLine($"Marka i model pojazdu: {car.Brand}");
            Console.WriteLine($"Całkowita cena wypożyczenia: {okresWypozyczenia * car.Price * LessThen4years}ZŁ");
            break;

        }
       
    }
    if (!carfound)
    {
        Console.WriteLine("Brak samochodu w ofercie");
    }
}
else if (userinput == 3)
{
    System.Environment.Exit(1);
}