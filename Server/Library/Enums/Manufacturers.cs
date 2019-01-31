using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Enums
{
    public enum Manufacturers
    {
        Manufacturers = 0,

        [CarDescription("http://cdn1.carbuyer.co.uk/sites/carbuyer_d7/files/styles/thumbnail/public/ALFAROMEO_0.png?itok=i6M9OKre", "Alfa Romeo is an Italian manufacturer with a reputation for designing stylish cars aimed at driving enthusiasts and families. With a rich history, Alfa Romeo celebrated its centenary in 2010 and offers models ranging from a supermini to the first SUV in its history.")]
        AlfaRomeo,
        [CarDescription("http://cdn1.carbuyer.co.uk/sites/carbuyer_d7/files/styles/thumbnail/public/AUDI_0.png?itok=LsKo4E6o", "Audi produces a wide range of cars, ranging from the VW Polo-sized A1 to the giant Range Rover-rivalling Q7 SUV. The German firm’s reputation is built on high technology, particularly its race-winning diesel engines, and high quality interiors.")]
        Audi,
        [CarDescription("http://cdn2.carbuyer.co.uk/sites/carbuyer_d7/files/styles/thumbnail/public/BMW_0.png?itok=uRKoB6mS", "BMW’s range of cars is designed with the driver in mind; most of its models feature rear-wheel drive and decent handling. Much like its main rival Mercedes, BMW offers a car for every niche, from saloons of all sizes to luxury SUVs and sports cars, as well as high-performance specials sporting the famous ‘M’ badge. It also pioneered the luxury electric segment with its i3 and i8 models.")]
        BMW,
        [CarDescription("http://cdn2.carbuyer.co.uk/sites/carbuyer_d7/files/styles/thumbnail/public/Picture%207_8.png?itok=GOcrVp9R", "Despite having a varied range of models, Chevrolet has pulled its mainstream line-up from the UK market, although independent specialists can still sell you a Corvette sports car.")]
        Chevrolet,
        [CarDescription("http://cdn1.carbuyer.co.uk/sites/carbuyer_d7/files/styles/thumbnail/public/CITROEN.png?itok=4n46uVjh", "Citroen's cars offer style, comfort and good value, with most featuring economical diesel engines and long lists of standard equipment. Citroen has in recent years split its DS-badged cars (the DS 3, DS 4 and DS 5) into a separate brand, simply called DS. It's an effort to make those models feel more upmarket, but for now, you're still be able to buy and service DS models at your local Citroen dealer.")]
        Citroen,
        [CarDescription("http://cdn1.carbuyer.co.uk/sites/carbuyer_d7/files/styles/thumbnail/public/FORD.png?itok=4scx2ZoA", "Ford is the biggest car brand in the UK, regularly topping sales charts and with almost 800 dealerships dotted all over the country. Its family-orientated model range spans from the Ka+ supermini to the seven-seat Galaxy MPV, while enthusiasts are catered for by ST and RS hot hatchbacks, not to mention the iconic Mustang.")]
        Ford,
        [CarDescription("http://cdn1.carbuyer.co.uk/sites/carbuyer_d7/files/styles/thumbnail/public/honda-logo_0.jpg?itok=zhRbZ9yn", "Honda has a reputation for producing cars to a very high engineering standard, ensuring good build quality, great engines and decent reliability. The Japanese company has a factory in the UK that builds many of its best-selling models, including the Civic.")]
        Honda,
        [CarDescription("http://cdn2.carbuyer.co.uk/sites/carbuyer_d7/files/styles/thumbnail/public/HYUNDAI.png?itok=mdrfKzZu", "Hyundai is a South Korean carmaker that made its name with simple, great-value family cars. Its latest models are well equipped and use increasingly sophisticated technology, and aren’t at all behind the times when it comes to style. Although most Hyundai cars use petrol and diesel engines, Hyundai also offers hybrid and pure-electric models, with more likely in the future. The company also enjoys a strong reputation for customer satisfaction and its cars are backed by a five-year/unlimited-mileage warranty.")]
        Hyundai,
        [CarDescription("http://cdn2.carbuyer.co.uk/sites/carbuyer_d7/files/styles/thumbnail/public/kia.jpg?itok=QgqbFSHT", "Kia is the sister brand of Hyundai, and offers a similarly wide range of well built family cars that are competitively priced and all come with a seven-year warranty. From the small Kia Picanto city car to the new Kia Sportage, there's something in the range to suit the vast majority of tastes.")]
        KIA,
        [CarDescription("http://cdn1.carbuyer.co.uk/sites/carbuyer_d7/files/styles/thumbnail/public/Mazda.jpg?itok=m7_I8WM0", "If you’re a keen driver and like to take the path less travelled, the Mazda offers a great range of models, all of which are attractive, drive well and offer a decent alternative to the mainstream. The Japanese firm builds superminis, family hatchbacks, saloons and SUVs, as well the fantastic MX-5 sports car.")]
        Mazda,
        [CarDescription("http://cdn1.carbuyer.co.uk/sites/carbuyer_d7/files/styles/thumbnail/public/MERCEDES-BENZ.png?itok=pGOsOMkM", "Mercedes offers a wide range of cars from the compact A-Class right up to the luxurious S-Class, GLE SUV and high-performance AMG GT sports car. The German firm has one of the best images in the industry, so while its models aren’t cheap, they generally hold their value.")]
        Mercedes,
        [CarDescription("http://cdn1.carbuyer.co.uk/sites/carbuyer_d7/files/styles/thumbnail/public/mitsubishi-logo_0.jpg?itok=f1bkDX_U", "Mitsubishi is a Japanese brand that produces a range of keenly priced, reliable and often interesting cars. Excellent plug-in hybrids and work-ready 4x4s are its speciality.")]
        Mitsubishi,
        [CarDescription("http://cdn1.carbuyer.co.uk/sites/carbuyer_d7/files/styles/thumbnail/public/Nissan.jpg?itok=l6dgWGBO", "One of the big players in the car world, Japanese firm Nissan sells a range of vehicles in the UK, with a focus on hatchbacks, crossover SUVs and sports cars, as well as all-electric vehicles. Whichever Nissan you chose, reliability and decent build quality are guaranteed.")]
        Nissan,
        [CarDescription("http://cdn1.carbuyer.co.uk/sites/carbuyer_d7/files/styles/thumbnail/public/renault_logo_0.png?itok=Onjex049", "Renault is a French manufacturer specialising in practical hatchbacks and larger family cars. All are adventurously styled, good to drive and well-equipped. Reasonable running costs and excellent safety ratings are common across the range.")]
        Renault,
        [CarDescription("http://cdn1.carbuyer.co.uk/sites/carbuyer_d7/files/styles/thumbnail/public/seat-logo.jpg?itok=7Ky7slwW", "SEAT is a Spanish car company that’s owned by the Volkswagen Group. Its cars use VW underpinnings and offer great build quality, sharp design and plenty of driver appeal.")]
        Seat,
        [CarDescription("http://cdn1.carbuyer.co.uk/sites/carbuyer_d7/files/styles/thumbnail/public/skoda20logo_0.jpg?itok=WeYI71Xh", "Skoda makes cars that are practical, well-built and great value for money. As part of the Volkswagen Group, Skoda’s cars have lots in common with their more expensive VW-badged counterparts.")]
        Skoda,
        [CarDescription("http://cdn1.carbuyer.co.uk/sites/carbuyer_d7/files/styles/thumbnail/public/SUBARU.png?itok=Nm3W6GF-", "Subaru’s reputation is built on its devotion to four-wheel drive, flat-four engines and excellent reliability. Its hatchbacks and estates are solidly built, well-equipped and particularly good in bad weather, while sportier offerings draw from the firm’s motorsport history.")]
        Subaru,
    }
}
