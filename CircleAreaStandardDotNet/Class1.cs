using System;
using System.Linq;

namespace CircleAreaStandardDotNet
{
    public class Figure
    {
        public double[] sides { get; private set; }

        public Figure(double[] sidesArr)
        {
            sides = sidesArr;
        }

        public void IsValidQuadrangle()
        {
            // some code
        }

        public double GetPerimeter()
        {
            if (!IsCircle())
            {
                double p = 0;
                foreach (double item in sides)
                {
                    p += item;
                }

                return p;
            }
            else
            {
                return Single.NaN;
            }
        }

        public bool IsValidTriangle()
        {
            if (sides.Length == 3)
            {
                double p = GetPerimeter();

                foreach (double item in sides)
                {
                    if ((p / 2 - item) < 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsRightAngledTriangle()
        {
            var gipotenuza = sides.Max();

            var catet1 = sides.Where(x => x != gipotenuza).First();
            var catet2 = sides.Where(x => x != gipotenuza && x != catet1).First();

            if (gipotenuza * gipotenuza == (Math.Pow(catet1, 2) + Math.Pow(catet2, 2)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetArea()
        {

            if (IsCircle())
            {
                return Math.PI * sides[0] * sides[0];
            }

            if (IsValidTriangle())
            {
                if (IsRightAngledTriangle())
                {
                    Console.WriteLine("Right-Angled!");
                }
                double p = GetPerimeter() / 2;

                double tmp = p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]);

                var result = Math.Sqrt(tmp);
                return result;
            }
            else
            {
                return Single.NaN;
            }

        }

        public double GetAreaSwitch()
        {
            double result = 0;

            string type = GetFigureType();

            switch (type)
            {

                case "Circle":
                    result = Math.PI * sides[0] * sides[0];
                    break;

                case "Triangle":
                    result = GetTriangleArea();
                    break;

                case "Quadrangle":
                    result = GetQuadrangleArea();

                    break;


                default:
                    Console.WriteLine("");
                    break;
            }
            return result;
        }

        private double GetQuadrangleArea()
        {
            double result = 0;
            if (IsRightQuadrangle())
            {
                result = sides[0] * sides[1];
            }

            return result;
        }

        private double GetTriangleArea()
        {
            double result;
            if (IsRightAngledTriangle())
            {
                Console.WriteLine("Right-Angled!");
            }
            double p = GetPerimeter() / 2;

            double tmp = p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]);

            result = Math.Sqrt(tmp);
            return result;
        }

        private bool IsRightQuadrangle()
        {
            if (sides[0] == sides[2] && sides[1] == sides[3] && sides[1] != sides[3])
            {
                return true;
            }

            return false;
        }

        public string GetFigureType()
        {
            return "";
        }

        private bool IsCircle()
        {
            return (sides.Length == 1) ? true : false;
        }
    }

}
