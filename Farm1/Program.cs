using System;
using System.Collections.Generic;
using Farm1;

namespace Farm1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Loktyshi = new Farm();
            {
                Loktyshi.FarmName = "Loktyshi";
                Loktyshi.FarmArea = 10500;
                var Buildings = new List<Building>();
                {
                    Building Barn1 = new Building() { Name = "Barn1", BuildingArea = 150, AnimalsInBarn = new List<Animal>(5) };
                    {
                        Animal Zorka = new Animal() { Type = AnimalType.cow, Product = AnimalProductType.milk, ProductWeight = 10 };
                        Animal Buronka = new Animal() { Type = AnimalType.cow, Product = AnimalProductType.milk, ProductWeight = 8 };
                        Animal Mashka = new Animal() { Type = AnimalType.goat, Product = AnimalProductType.milk, ProductWeight = 5 };
                        Animal Stepanida = new Animal() { Type = AnimalType.goat, Product = AnimalProductType.milk, ProductWeight = 4 };
                        Animal Arkadii = new Animal() { Type = AnimalType.horse, Product = AnimalProductType.meat, ProductWeight = 150 };
                    }
                    Building Barn2 = new Building() { Name = "Barn2", BuildingArea = 120, AnimalsInBarn = new List<Animal>(5) };
                    {
                        Animal Katia = new Animal() { Type = AnimalType.sheep, Product = AnimalProductType.wool, ProductWeight = 3 };
                        Animal Vasya = new Animal() { Type = AnimalType.sheep, Product = AnimalProductType.wool, ProductWeight = 5 };
                        Animal Dolly = new Animal() { Type = AnimalType.sheep, Product = AnimalProductType.wool, ProductWeight = 2 };
                        Animal Dereza = new Animal() { Type = AnimalType.goat, Product = AnimalProductType.milk, ProductWeight = 2 };
                    }
                    Building Barn3 = new Building() { Name = "Barn3", BuildingArea = 100, AnimalsInBarn = new List<Animal>(10) };
                    {
                        Animal Seryi = new Animal() { Type = AnimalType.goose, Product = AnimalProductType.meat, ProductWeight = 7 };
                        Animal Belyi = new Animal() { Type = AnimalType.goose, Product = AnimalProductType.meat, ProductWeight = 8 };
                        Animal Riaba1 = new Animal() { Type = AnimalType.hen, Product = AnimalProductType.eggs, ProductWeight = 1 };
                        Animal Riaba2 = new Animal() { Type = AnimalType.hen, Product = AnimalProductType.eggs, ProductWeight = 2 };
                        Animal Riaba3 = new Animal() { Type = AnimalType.hen, Product = AnimalProductType.eggs, ProductWeight = 2 };
                        Animal Riaba4 = new Animal() { Type = AnimalType.hen, Product = AnimalProductType.eggs, ProductWeight = 1 };
                    }

                };

                var GardenBeds = new List<GardenBed>();
                {
                    new GardenBed() { GardenBedArea = 1500, ListOfPlants = new List<Plant>() };
                    {
                        new Plant() { Type = PlantType.potatoe, Planting = Seasons.spring, Harvesting = Seasons.autumn, OccupiedArea = 250 };
                        new Plant() { Type = PlantType.carrot, Planting = Seasons.spring, Harvesting = Seasons.autumn, OccupiedArea = 100 };
                    }
                    new GardenBed() { GardenBedArea = 400, ListOfPlants = new List<Plant>() };
                    {
                        new Plant() { Type = PlantType.tomatoe, Planting = Seasons.spring, Harvesting = Seasons.autumn, OccupiedArea = 100 };
                        new Plant() { Type = PlantType.cucumber, Planting = Seasons.spring, Harvesting = Seasons.autumn, OccupiedArea = 200 };
                    }
                    new GardenBed() { GardenBedArea = 150, ListOfPlants = new List<Plant>() };
                    new Plant() { Type = PlantType.onion, Planting = Seasons.spring, Harvesting = Seasons.autumn, OccupiedArea = 50 };

                };



                Loktyshi.FarmInfo();
                
                }
                
                
            
            }
            }

       

        }
   

