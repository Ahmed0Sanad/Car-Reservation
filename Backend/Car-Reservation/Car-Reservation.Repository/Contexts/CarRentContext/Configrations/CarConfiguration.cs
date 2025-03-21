﻿using Car_Reservation_Domain.Entities.CarEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Car_Reservation.Repository.Contexts.CarRentContext.Configrations
{
    class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasMany(c => c.Reservations).WithOne(r => r.car);
            builder.HasMany(c => c.Reviews).WithOne(r => r.Car);
            builder.HasOne(c => c.Admin).WithMany();

            builder.Property(c => c.Url).HasMaxLength(500);

            builder.HasData(
                 new Car() { Id = 1, Name = "Ford Mustang", ModelId = 1, BrandId = 2, IsAvailable = true, Url = "https://th.bing.com/th/id/OIP.shICukY9MAFIZZ2fY8GCogHaEA?rs=1&pid=ImgDetMain", Rating = 4.7, InsuranceCost = 428, Price = 127 },
                 new Car() { Id = 2, Name = "Toyota Camry", ModelId = 2, BrandId = 1, IsAvailable = true, Url = "https://th.bing.com/th/id/R.ee3a8eb625b80e8a339ba413b6083356?rik=EqglPbjWgbUQWA&pid=ImgRaw&r=0", Rating = 4.5, InsuranceCost = 275, Price = 85 },
                 new Car() { Id = 3, Name = "BMW 3 Series", ModelId = 3, BrandId = 3, IsAvailable = true, Url = "https://cdn.motor1.com/images/mgl/174Wp/s1/2019-bmw-3-series.jpg", Rating = 4.6, InsuranceCost = 498, Price = 146 },
                 new Car() { Id = 4, Name = "Mercedes-Benz C-Class", ModelId = 4, BrandId = 4, IsAvailable = true, Url = "https://th.bing.com/th/id/OIP.x0Rg9xavRsO8l2YJYZ2-gQHaEK?rs=1&pid=ImgDetMain", Rating = 4.8, InsuranceCost = 520, Price = 154 },
                 new Car() { Id = 5, Name = "Honda Civic", ModelId = 5, BrandId = 5, IsAvailable = true, Url = "https://th.bing.com/th/id/R.5716f82fcc49a849949faa979ec89993?rik=blR%2fh2NedLFhfA&pid=ImgRaw&r=0", Rating = 4.4, InsuranceCost = 254, Price = 78 },
                 new Car() { Id = 6, Name = "Chevrolet Corvette", ModelId = 6, BrandId = 6, IsAvailable = false, Url = "https://th.bing.com/th/id/R.ae0112d018f6411a2bdd2d8f1836c365?rik=ob60KY04v5sRHQ&riu=http%3a%2f%2fwww.ausmotive.com%2fpics%2f2013%2fChevrolet-Corvette-Stingray-02.jpg&ehk=1m9%2fMf269WkLWAORDdRyY%2bcNI9xZJ1D9sTzqEzyL3Y0%3d&risl=&pid=ImgRaw&r=0", Rating = 4.9, InsuranceCost = 625, Price = 198 },
                 new Car() { Id = 7, Name = "Nissan Altima", ModelId = 7, BrandId = 7, IsAvailable = true, Url = "https://th.bing.com/th/id/R.ab06dccb5178c4ac5600833a47e5ccb9?rik=EyIkcPS33piZNw&pid=ImgRaw&r=0", Rating = 4.0, InsuranceCost = 287, Price = 82 },
                 new Car() { Id = 8, Name = "Hyundai Sonata", ModelId = 8, BrandId = 8, IsAvailable = true, Url = "https://th.bing.com/th/id/R.a2ab007ce1b2485af4724930ab407b47?rik=y2UaMIaJAuLAzQ&pid=ImgRaw&r=0", Rating = 4.2, InsuranceCost = 265, Price = 76 },
                 new Car() { Id = 9, Name = "Kia Optima", ModelId = 9, BrandId = 9, IsAvailable = true, Url = "https://th.bing.com/th/id/R.557a504bc2e45044c335018d3ce9ad62?rik=37PqlpPKJl7Hkg&pid=ImgRaw&r=0", Rating = 4.1, InsuranceCost = 260, Price = 75 },
                 new Car() { Id = 10, Name = "Volkswagen Golf", ModelId = 10, BrandId = 10, IsAvailable = true, Url = "https://th.bing.com/th/id/R.07bb929fafa610a35127831042ea774e?rik=XMI7vJ0h5AZTUw&pid=ImgRaw&r=0", Rating = 4.3, InsuranceCost = 290, Price = 87 },
                 new Car() { Id = 11, Name = "Subaru Outback", ModelId = 11, BrandId = 11, IsAvailable = true, Url = "https://th.bing.com/th/id/R.b3cc66d690c6bed677061358dd20c804?rik=Xm7irkrDMOwOHw&pid=ImgRaw&r=0", Rating = 4.6, InsuranceCost = 310, Price = 93 },
                 new Car() { Id = 12, Name = "Mazda CX-5", ModelId = 12, BrandId = 12, IsAvailable = true, Url = "https://th.bing.com/th/id/R.69334b92d94e652496b1d537a313a3f4?rik=hfxCetakvC%2fdyA&pid=ImgRaw&r=0", Rating = 4.5, InsuranceCost = 305, Price = 92 },
                 new Car() { Id = 13, Name = "Lexus ES", ModelId = 13, BrandId = 13, IsAvailable = true, Url = "https://th.bing.com/th/id/R.36978b49382491ae7db58ab0d036af5a?rik=VcnskkblDSQX%2fQ&pid=ImgRaw&r=0", Rating = 4.7, InsuranceCost = 425, Price = 134 },
                 new Car() { Id = 14, Name = "Dodge Charger", ModelId = 14, BrandId = 14, IsAvailable = true, Url = "https://www.motortrend.com/uploads/sites/5/2016/05/2016-Dodge-Charger-SRT-Hellcat-front-three-quarter-in-motion-10-e1463002496685.jpg", Rating = 4.4, InsuranceCost = 415, Price = 124 },
                 new Car() { Id = 15, Name = "Jeep Wrangler", ModelId = 15, BrandId = 15, IsAvailable = true, Url = "", Rating = 4.6, InsuranceCost = 398, Price = 119 },
                 new Car() { Id = 16, Name = "Tesla Model 3", ModelId = 16, BrandId = 16, IsAvailable = true, Url = "https://facts.net/wp-content/uploads/2023/12/15-jeep-wrangler-facts-1701628021.jpeg", Rating = 4.8, InsuranceCost = 380, Price = 129 },
                 new Car() { Id = 17, Name = "Volvo XC90", ModelId = 17, BrandId = 17, IsAvailable = true, Url = "https://th.bing.com/th/id/OIP.4yE72-7g-iODnnSdz0ix_AHaE8?rs=1&pid=ImgDetMain", Rating = 4.7, InsuranceCost = 510, Price = 152 },
                 new Car() { Id = 18, Name = "Porsche 911", ModelId = 18, BrandId = 18, IsAvailable = false, Url = "https://th.bing.com/th/id/OIP.V3nD0p-Bhf-TivgmJaYR0wHaEK?rs=1&pid=ImgDetMain", Rating = 4.9, InsuranceCost = 815, Price = 320 },
                 new Car() { Id = 19, Name = "Toyota Corolla", ModelId = 19, BrandId = 1, IsAvailable = true, Url = "https://i.ytimg.com/vi/nMuGDd0bcog/maxresdefault.jpg", Rating = 4.3, InsuranceCost = 240, Price = 68 },
                 new Car() { Id = 20, Name = "Ford Explorer", ModelId = 20, BrandId = 2, IsAvailable = true, Url = "https://th.bing.com/th/id/OIP.FvUR3d2kbE4N8Pde3udA-wHaEK?rs=1&pid=ImgDetMain", Rating = 4.2, InsuranceCost = 375, Price = 115 },
                 new Car() { Id = 21, Name = "BMW X5", ModelId = 1, BrandId = 3, IsAvailable = true, Url = "https://media.autoexpress.co.uk/image/private/s--VfWlNFGx--/v1609948123/autoexpress/2021/01/New%20BMW%20X5%20M%20Competition%202021%20UK-16.jpg", Rating = 4.7, InsuranceCost = 610, Price = 175 },
                 new Car() { Id = 22, Name = "Mercedes-Benz GLC", ModelId = 2, BrandId = 4, IsAvailable = true, Url = "https://cdn.motor1.com/images/mgl/Z2PX2/s1/mercedes-benz-glc-2019.jpg", Rating = 4.6, InsuranceCost = 580, Price = 165 },
                 new Car() { Id = 23, Name = "Honda Accord", ModelId = 3, BrandId = 5, IsAvailable = true, Url = "https://th.bing.com/th/id/OIP.vLa2-0XiaioyXd6XqY3Y9gHaE8?w=302&h=201&c=7&r=0&o=5&dpr=2.5&pid=1.7", Rating = 4.5, InsuranceCost = 270, Price = 82 },
                 new Car() { Id = 24, Name = "Chevrolet Camaro", ModelId = 4, BrandId = 6, IsAvailable = true, Url = "https://th.bing.com/th/id/OIP.I_mwW1qXjvCbHAWzSuUt_QHaEo?w=254&h=180&c=7&r=0&o=5&dpr=2.5&pid=1.7", Rating = 4.5, InsuranceCost = 480, Price = 143 },
                 new Car() { Id = 25, Name = "Nissan Maxima", ModelId = 5, BrandId = 7, IsAvailable = true, Url = "https://th.bing.com/th/id/OIP.aYtcYYlbK1xY62VvCrf7dgHaFj?w=223&h=180&c=7&r=0&o=5&dpr=2.5&pid=1.7", Rating = 4.2, InsuranceCost = 320, Price = 93 },
                 new Car() { Id = 26, Name = "Hyundai Tucson", ModelId = 6, BrandId = 8, IsAvailable = true, Url = "https://th.bing.com/th/id/OIP.zcXWOJgHE8edDLgtJHnQfgHaEK?w=319&h=180&c=7&r=0&o=5&dpr=2.5&pid=1.7", Rating = 4.3, InsuranceCost = 270, Price = 82 },
                 new Car() { Id = 27, Name = "Kia Sportage", ModelId = 7, BrandId = 9, IsAvailable = true, Url = "https://th.bing.com/th/id/OIP.H0qqCl2_b0BRTzsnEtO2pgHaE7?w=236&h=180&c=7&r=0&o=5&dpr=2.5&pid=1.7", Rating = 4.2, InsuranceCost = 265, Price = 80 },
                 new Car() { Id = 28, Name = "Subaru Forester", ModelId = 9, BrandId = 11, IsAvailable = true, Url = "https://th.bing.com/th/id/OIP.T3RIbguC2smX2ORvr-ooYgAAAA?w=317&h=180&c=7&r=0&o=5&dpr=2.5&pid=1.7", Rating = 4.5, InsuranceCost = 300, Price = 90 },
                 new Car() { Id = 29, Name = "Lexus RX", ModelId = 11, BrandId = 13, IsAvailable = true, Url = "https://th.bing.com/th/id/OIP.oxWUD74TkCzaq-UR_1ImWgHaE8?w=284&h=189&c=7&r=0&o=5&dpr=2.5&pid=1.7", Rating = 4.7, InsuranceCost = 455, Price = 142 },
                 new Car() { Id = 30, Name = "Dodge Challenger", ModelId = 12, BrandId = 14, IsAvailable = true, Url = "https://th.bing.com/th/id/OIP.XuTj_zjpeMBtD-PBP0XVUAHaE8?rs=1&pid=ImgDetMain", Rating = 4.5, InsuranceCost = 430, Price = 128 },
                 new Car() { Id = 31, Name = "Jeep Grand Cherokee", ModelId = 13, BrandId = 15, IsAvailable = true, Url = "https://th.bing.com/th/id/OIP.DxWQK5PuVQx0n5RHxwoN4gHaE8?rs=1&pid=ImgDetMain", Rating = 4.4, InsuranceCost = 410, Price = 125 }
             );

        }
    }
}
