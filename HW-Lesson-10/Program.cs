using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ref and out

            #region Q-2

            //int a = 2, b = 2;
            //Question2(ref a, ref b);
            //Console.WriteLine(a + " " + b);
            //Console.WriteLine();

            #endregion

            #region Q-3

            //int c, d;
            //Question3(out c, out d);
            //Console.WriteLine(c + " " + d);

            #endregion

            #region Q-4

            //string errorMessage1;

            //Console.WriteLine("first name:");
            //string fn = Console.ReadLine();
            //Console.WriteLine("last name:");
            //string ln = Console.ReadLine();
            //Console.WriteLine("phone number:");
            //string pn = Console.ReadLine();
            //Console.WriteLine("id:");
            //string id = Console.ReadLine();
            //Console.WriteLine("age:");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine(ValidateValues(phoneNum: pn, lastName: ln, firstName: fn, age: age,id: id, errorMessage: out errorMessage1) + "\n" + errorMessage1);

            #endregion

            #endregion

            #region params, in named and optional args

            #region Q-1

            //Console.WriteLine(SumOfNumber(6, 54, 87, 2, 3, 45));

            #endregion

            #region Q-2+3

            // Abc(1, c: 10);

            #endregion

            #region Q-4

            // Console.WriteLine(CrazyClient(9));

            #endregion

            #region Q-5

            //CellPhone c1 = new CellPhone();
            //Console.WriteLine(c1);
            //Console.WriteLine();
            //CellPhone c2 = new CellPhone(model: "iPhone", cameraQuality: 5);
            //Console.WriteLine(c2);
            //Console.WriteLine();
            //CellPhone c3 = new CellPhone(battery: 12, screenSize: 12.3f, cameraQuality: 1, model: "Nokia");
            //Console.WriteLine(c3);
            //Console.WriteLine();
            //CellPhone c4 = new CellPhone(screenSize: 10, model: "OnePlus", cameraQuality: 10, battery: 79);
            //Console.WriteLine(c4);
            //Console.WriteLine();

            #endregion

            #endregion

            #region Method Advance Exercises

            #region Functions Overloading

            #region Q-1

            //PrintInTwoRows("a", "b");
            //PrintInTwoRows(10, 65);
            //PrintInTwoRows(4 > 3, !(54 == 87));

            #endregion

            #region Q-2

            //Calculator c = new Calculator();

            //Console.WriteLine(c.Calc(10, 5, '+'));
            //Console.WriteLine(c.Calc(10, 5, '-'));
            //Console.WriteLine(c.Calc(10, 5, '*'));
            //Console.WriteLine(c.Calc(10, 5, '/'));
            //Console.WriteLine();
            //Console.WriteLine(c.Calc(10, 5, '+'));
            //Console.WriteLine(c.Calc(10, 5, '-'));
            //Console.WriteLine(c.Calc(10, 5, '*'));
            //Console.WriteLine(c.Calc(10, 5, '/'));
            //Console.WriteLine();
            //Console.WriteLine(c.Calc("10", "5", '+'));
            //Console.WriteLine(c.Calc("10", "5", '-'));
            //Console.WriteLine(c.Calc("10", "5", '*'));
            //Console.WriteLine(c.Calc("10", "5", '/'));
            //Console.WriteLine();               

            #endregion

            #endregion

            #region Ctors Overloading

            //Kitchen k = new Kitchen(4000, 500, 700, 2000, "BlAck", 10, true);
            //Console.WriteLine(k._totalPrice);

            #endregion

            #region virtual and override

            //Bird chick = new Chicken();
            //Bird tuk = new LazyTukon();
            //Chicken chicke = new Chicken();
            //LazyTukon lazTuk = new LazyTukon();

            //Console.WriteLine("Bird-Chicken");
            //chick.Fly();
            //chick.Shower();
            //Console.WriteLine();
            //Console.WriteLine("Bird-tukon");
            //tuk.Fly();
            //tuk.Shower();
            //Console.WriteLine();
            //Console.WriteLine("Chicken");
            //chicke.Fly();
            //chicke.Shower();
            //Console.WriteLine();
            //Console.WriteLine("tukon");
            //lazTuk.Fly();
            //lazTuk.Shower();

            #endregion

            #region new

            //Computer c = new Laptop(2000, "intel", true, 4.4f, "y");
            //Laptop l = new Laptop(2000, "intel", true, 4.4f, "y");
            //c.TurnOnOrOff();
            //Console.WriteLine(c.isOn);
            //l.TurnOnOrOff();
            //Console.WriteLine(l.isOn);

            #endregion

            #region this and base



            #endregion

            #endregion


            Console.ReadLine();
        }

        #region Method Advance Exercises

        #region Functions Overloading

        #region Q-1

        static void PrintInTwoRows(string a, string b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static void PrintInTwoRows(int a, int b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static void PrintInTwoRows(bool a, bool b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        #endregion

        #endregion


        #endregion

        #region ref and out

        static void Question2(ref int a, ref int b)
        {
            a++;
            b *= 2;
        }

        static void Question3(out int a, out int b)
        {
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            a++;
            b *= 2;
        }

        static bool ValidateValues(string firstName, string lastName, string phoneNum, string id, int age, out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrEmpty(firstName))
            {
                errorMessage += "first name is empty\n";
            }
            if (string.IsNullOrEmpty(lastName))
            {
                errorMessage += "last name is empty\n";
            }
            char[] phone = phoneNum.ToCharArray();
            if (phoneNum.Length < 9)
            {
                errorMessage += "phone number is shorter than 9 digits\n";
            }
            if (phone[0] != '0')
            {
                errorMessage += "phone number doesn't start with \"0\"\n";
            }
            if (id.Length != 9)
            {
                errorMessage += "id doesn't have 9 digits\n";
            }
            if (age < 1)
            {
                errorMessage += "age is smaller than 1\n";
            }
            if (age > 100)
            {
                errorMessage += "age is bigger than 100\n";
            }
            if (errorMessage == "")
            {
                return true;
            }
            else return false;
        }

        #endregion

        #region params, in named and optional args

        static long SumOfNumber(params int[] num)
        {
            long sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += (long)(num[i] * (i + 1));
            }
            return sum;
        }

        static void Abc(int a, int b = 1, int c = -1)
        {
            Console.WriteLine(a * b * c);
        }

        static int CrazyClient(in int n)
        {
            return n * 3;
        }

        #endregion
    }

    #region Method Advance Exercises

    #region Functions Overloading

    #region Q-2

    class Calculator
    {
        public int Calc(int n1, int n2, char operat)
        {
            int result = 0;
            switch (operat)
            {
                case '+':
                    result = n1 + n2;
                    break;

                case '-':
                    result = n1 - n2;
                    break;

                case '*':
                    result = n1 * n2;
                    break;

                case '/':
                    if (n2 != 0)
                    {
                        result = n1 / n2;
                    }
                    else
                    {
                        Console.WriteLine("You cannot divide by 0");
                    }
                    break;
            }
            return result;
        }

        public double Calc(double n1, double n2, char operat)
        {
            double result = 0;
            switch (operat)
            {
                case '+':
                    result = n1 + n2;
                    break;

                case '-':
                    result = n1 - n2;
                    break;

                case '*':
                    result = n1 * n2;
                    break;

                case '/':
                    if (n2 != 0)
                    {
                        result = n1 / n2;
                    }
                    else
                    {
                        Console.WriteLine("You cannot divide by 0");
                    }
                    break;
            }
            return result;
        }

        public int Calc(string n3, string n4, char operat)
        {
            int n1 = int.Parse(n3), n2 = int.Parse(n4);
            int result = 0;
            switch (operat)
            {
                case '+':
                    result = n1 + n2;
                    break;

                case '-':
                    result = n1 - n2;
                    break;

                case '*':
                    result = n1 * n2;
                    break;

                case '/':
                    if (n2 != 0)
                    {
                        result = n1 / n2;
                    }
                    else
                    {
                        Console.WriteLine("You cannot divide by 0");
                    }
                    break;
            }
            return result;
        }
    }



    #endregion

    #endregion

    #region Ctors Overloading

    class Kitchen
    {
        public int _totalPrice;
        public Kitchen(int fridge, int microwave, int dishwasher, int oven)
        {
            _totalPrice = fridge + microwave + dishwasher + oven;
        }

        public Kitchen(int fridge, int microwave, int dishwasher, int oven, string color, int sizeInMeters, bool isWindow) : this(fridge, microwave, dishwasher, oven)
        {
            if (color.ToLower() == "black")
            {
                _totalPrice += 200;
            }
            _totalPrice += (sizeInMeters * 5);
            if (isWindow)
            {
                _totalPrice += 500;
            }
        }
    }

    #endregion

    #region virtual and override

    class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Run, wave and take off");
        }
        public void Shower()
        {
            Console.WriteLine("Good Water For Shower");
        }
    }

    class Chicken: Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Sorry, I can't fly");
        }
    }
    class LazyTukon : Bird
    {
        new public void Shower()
        {
            Console.WriteLine("I'm so tired");
        }
    }

    #endregion

    #region new

    class Computer
    {
        public double price;
        public string processor;
        public bool isOn;

        public Computer()
        {

        }

        public Computer(double price, string processor, bool isOn)
        {
            this.price = price;
            this.processor = processor;
            this.isOn = isOn;
        }

        public void TurnOnOrOff()
        {
            this.isOn = !this.isOn;
        }
    }
    class Laptop : Computer
    {
        public float weight;
        public string wifi;

        public Laptop(double price, string processor, bool isOn, float weight, string wifi)
        {
            this.price = price;
            this.processor = processor;
            this.isOn = isOn;
            this.weight = weight;
            this.wifi = wifi;
        }
        new public void TurnOnOrOff()
        {
            Console.WriteLine("sleep... zZz zZz");
        }
    }

    #endregion

    #region this and base



    #endregion

    #endregion

    #region params, in named and optional args

    class CellPhone
    {
        public float screenSize;
        public string model;
        public int battery;
        public int cameraQuality;

        public CellPhone(float screenSize = 7.1f, string model = "Galaxy", int battery = 80, int cameraQuality = 3)
        {
            this.screenSize = screenSize;
            this.model = model;
            this.battery = battery;
            this.cameraQuality = cameraQuality;
        }
        public override string ToString()
        {
            string a = $"screenSize: {screenSize}\nmodel: {model}\nbattery = {battery}\ncamera quality = {cameraQuality}";
            return a;
        }
    }

    #endregion
}
