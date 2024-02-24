using wypozyczalnia;

List<Client> clientList = new List<Client>();

clientList.Add(new Client { Id = 1, Name = "Jan Nowak", DrivingLicenseDate = new DateTime(2021, 4, 3) });
clientList.Add(new Client { Id = 2, Name = "Agnieszka Kowalska", DrivingLicenseDate = new DateTime(1999, 1, 15) });
clientList.Add(new Client { Id = 3, Name = "Robert Lewandowski", DrivingLicenseDate = new DateTime(2010, 12, 18) });
clientList.Add(new Client { Id = 4, Name = "Zofia Płucińska", DrivingLicenseDate = new DateTime(2020, 4, 29) });
clientList.Add(new Client { Id = 5, Name = "Grzegorz Braun", DrivingLicenseDate = new DateTime(2015, 7, 12) });

List<Car> carList = new List<Car>();
carList.Add(new Car { Id = 1, Brand = "Skoda Citigo", Type = "mini", Engine = "Benzyna", Status = "dostępny", Price = 70 });
carList.Add(new Car { Id = 2, Brand = "Toyota Aygo", Type = "mini", Engine = "Benzyna", Status = "dostępny", Price = 90 });
carList.Add(new Car { Id = 3, Brand = "Fiat 500", Type = "mini", Engine = "elektryczny", Status = "dostępny", Price = 110 });
carList.Add(new Car { Id = 4, Brand = "Ford Focus", Type = "kompakt", Engine = "diesel", Status = "dostępny", Price = 160 });
carList.Add(new Car { Id = 5, Brand = "Kia Ceed", Type = "kompakt", Engine = "benzyna", Status = "dostępny", Price = 150 });
carList.Add(new Car { Id = 6, Brand = "Volkswagen Golf", Type = "kompakt", Engine = "benzyna", Status = "dostępny", Price = 160 });
carList.Add(new Car { Id = 7, Brand = "Hyundai Kona Electric", Type = "kompakt", Engine = "elektryczny", Status = "dostępny", Price = 180 });
carList.Add(new Car { Id = 8, Brand = "Audi A6 Allroad", Type = "premium", Engine = "diesel", Status = "dostępny", Price = 290 });
carList.Add(new Car { Id = 9, Brand = "Mercedes E270 AMG", Type = "premium", Engine = "benzyna", Status = "dostępny", Price = 320 });
carList.Add(new Car { Id = 10, Brand = "Tesla Model S", Type = "premium", Engine = "elektryczny", Status = "dostępny", Price = 350 });

foreach (var client in clientList)
{
    Console.WriteLine($"ID: {client.Id}, Name: {client.Name}, Driving License Date: {client.DrivingLicenseDate.ToShortDateString()}");
}

foreach (var car in carList)
{
    Console.WriteLine($"ID: {car.Id}, Name: {car.Brand}, Type: {car.Type}, Engine: {car.Engine}, Status: {car.Status}, Price: {car.Price}");
}