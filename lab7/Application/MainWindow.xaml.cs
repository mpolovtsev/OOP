using System;
using System.Collections.Generic;
using System.Windows;
using FlatsLibrary;

namespace Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Flat> flats = new List<Flat>();
        int amountOfRooms;
        string[]? areaOfRooms;
        double ceilingHeight;
        int amountOfWindows;
        bool furniture;
        string? furnitureValue; 
        int floor;
        bool washingMachine;
        string? washingMachineValue;
        double squareMeterCost;
        string? stove;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            amountOfRooms = int.Parse(amountOfRoomsTB.Text);
            areaOfRooms = areaOfRoomsTB.Text.Split();

            if (amountOfRooms == areaOfRooms.Length)
            {
                ceilingHeight = double.Parse(ceilingHeightTB.Text);
                amountOfWindows = int.Parse(amountOfWindowsTB.Text);

                if (furnitureTrue.IsChecked == true)
                {
                    furniture = true;
                    furnitureValue = furnitureTrue.Content.ToString();
                }
                else if (furnitureFalse.IsChecked == true)
                {
                    furniture = false;
                    furnitureValue = furnitureFalse.Content.ToString();
                }

                floor = int.Parse(floorTB.Text);

                if (washingMachineTrue.IsChecked == true)
                {
                    washingMachine = true;
                    washingMachineValue = washingMachineTrue.Content.ToString();
                }
                else if (washingMachineFalse.IsChecked == true)
                {
                    washingMachine = false;
                    washingMachineValue = washingMachineFalse.Content.ToString();
                }

                squareMeterCost = double.Parse(squareMeterCostTB.Text);

                if (stoveGas.IsChecked == true)
                    stove = stoveGas.Content.ToString();
                else if (stoveElectric.IsChecked == true)
                    stove = stoveElectric.Content.ToString();

                Flat flat = new Flat(amountOfRooms, ceilingHeight, amountOfWindows, 
                    furniture, floor, washingMachine, stove, squareMeterCost);

                switch (amountOfRooms)
                {
                    case 1:
                        flat = new OneRoomFlat(amountOfRooms, ceilingHeight, amountOfWindows, furniture,
                        floor, washingMachine, stove, squareMeterCost, double.Parse(areaOfRooms[0]));
                        break;
                    case 2:
                        flat = new TwoRoomFlat(amountOfRooms, ceilingHeight, amountOfWindows, furniture,
                        floor, washingMachine, stove, squareMeterCost, double.Parse(areaOfRooms[0]),
                        double.Parse(areaOfRooms[1]));
                        break;
                    case 3:
                        flat = new ThreeRoomFlat(amountOfRooms, ceilingHeight, amountOfWindows, furniture,
                        floor, washingMachine, stove, squareMeterCost, double.Parse(areaOfRooms[0]),
                        double.Parse(areaOfRooms[1]), double.Parse(areaOfRooms[2]));
                        break;
                    case 4:
                        flat = new FourRoomFlat(amountOfRooms, ceilingHeight, amountOfWindows, furniture,
                        floor, washingMachine, stove, squareMeterCost, double.Parse(areaOfRooms[0]),
                        double.Parse(areaOfRooms[1]), double.Parse(areaOfRooms[2]), double.Parse(areaOfRooms[3]));
                        break;
                    case 5:
                        flat = new FiveRoomFlat(amountOfRooms, ceilingHeight, amountOfWindows, furniture,
                        floor, washingMachine, stove, squareMeterCost, double.Parse(areaOfRooms[0]),
                        double.Parse(areaOfRooms[1]), double.Parse(areaOfRooms[2]), double.Parse(areaOfRooms[3]), 
                        double.Parse(areaOfRooms[4]));
                        break;
                }

                flatInfo.Content += $"Комнаты - {amountOfRooms}, высота потолка - {ceilingHeight}, окна - {amountOfWindows}, " +
                $"мебель - {furnitureValue}, этаж - {floor}, стиральная машина - {washingMachineValue}, тип кухонной плиты - {stove}, " +
                $"стоимоcть 1 кв. м. - {squareMeterCost}\n";
                flats.Add(flat);
            }
            else
            {
                MessageBox.Show("Количество введенных площадей комнат не соответствует количеству комнат.");
            }
        }

       private void method1_Click(object sender, RoutedEventArgs e)
       {
            double rent = 0;
            double square = 0;

            foreach (var flat in flats)
            {
                if (flat.amountOfRooms == 3)
                {
                    rent += flat.GetRent();
                    square += flat.GetSquare();
                }
            }

            if (rent == 0)
            {
                result1.Content = "Трёхкомнатных квартир не найдено.";
            }
            else
            {
                result1.Content = $"{Math.Round(rent / square, 2)}";
            }
       }

        private void method2_Click(object sender, RoutedEventArgs e)
        {
            int oneRoom = 0;
            int twoRoom = 0;
            int threeRoom = 0;
            int fourRoom = 0;
            int fiveRoom = 0;

            foreach (var flat in flats)
            {
                switch (flat.amountOfRooms)
                {
                    case 1:
                        oneRoom++;
                        break;
                    case 2:
                        twoRoom++;
                        break;
                    case 3:
                        threeRoom++;
                        break;
                    case 4:
                        fourRoom++;
                        break;
                    case 5:
                        fiveRoom++;
                        break;
                }
            }

            result2.Content = $"1 комната - {oneRoom}, 2 комнаты - {twoRoom}, 3 комнаты - {threeRoom}, 4 комнаты - {fourRoom}, 5 комнат - {fiveRoom}";
        }

        private void method3_Click(object sender, RoutedEventArgs e)
        {
            result3.Content = "";

            foreach (var flat in flats)
            {
                if (flat.stove == "Электрическая")
                {
                    string furnitureValue = flat.furniture ? "Есть" : "Нет";
                    string washingMachineValue = flat.washingMachine ? "Есть" : "Нет";

                    result3.Content += $"Комнаты - {flat.amountOfRooms}, высота потолка - {flat.ceilingHeight}, окна - {flat.amountOfWindows}, " +
                    $"мебель - {furnitureValue}, этаж - {flat.floor}, стиральная машина - {washingMachineValue}, тип кухонной плиты - {flat.stove}, " +
                    $"стоимоcть 1 кв. м. - {flat.squareMeterCost}\n";
                }
            }
        }
    }
}
