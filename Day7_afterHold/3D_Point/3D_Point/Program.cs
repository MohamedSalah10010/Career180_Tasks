namespace _3D_Point
{
 
 internal class Program
    {
        private static void LogError(string message)
        {
            using (StreamWriter writer = new StreamWriter("error_log.txt", true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }
        static void Main(string[] args)
        {
            bool flag=true;
            int counter = 1;
            //Point3D p = new Point3D(1,1, 1);
            //Point3D p1 = new Point3D(2, 2, 2);
            //Point3D p2 = new Point3D(1,1, 1);
            List<Point3D> points = new List<Point3D>();
            do
            {
                try
                {
                    Console.WriteLine($"Enter the coordinate of point {counter}: ");
                    Console.Write($"Enter X{counter}: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write($"Enter Y{counter}: ");
                    int y;
                    bool y_status = int.TryParse(Console.ReadLine(), out y);
                    Console.Write($"Enter Z{counter}: ");
                    int z = Convert.ToInt32(Console.ReadLine());

                    Point3D point=new Point3D(x,y,z);
                    points.Add(point);
                    Console.Write("Do you want to add more points (YES / NO)?");
                    string choice = Console.ReadLine();
                    
                    if (choice?.ToUpper() != "Y" && choice?.ToUpper() != "YES")
                    {
                        flag = false; 
                    }

                    counter++;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid format! Please enter a valid integer.");
                    LogError(ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("The number entered is too large or too small for an integer.");
                    LogError(ex.Message);
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Input cannot be null.");
                    LogError(ex.Message);
                }

            } while (flag);

            foreach (Point3D i in points) {

                Console.WriteLine( i.ToString() );
            }
            Console.ReadKey();

        }
    }

    public class Point3D
    {
        public static int ID=1;
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int x = 0,int y = 0, int z=0)
        {
                X = x;
                Y = y;
                Z = z;
                ID++;
        }

        public override string ToString()
        {
            return $"Point{ID} ({X} , {Y} , {Z})";
        }
        public override bool Equals(object? obj)
        {
            

            if (obj is Point3D point) {

                return (this.X == point.X && this.Y == point.Y && this.Z == point.Z);

            }
            else throw new FormatException(" The input parameter is not Point3D object") ;


        }
        public static Point3D operator +(Point3D p1, Point3D p2) 
        {

            return new Point3D(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
        }

        public static Point3D operator -(Point3D p1, Point3D p2)
        {

            return new Point3D(p1.X - p2.X, p1.Y - p2.Y, p1.Z - p2.Z);
        }

        public static bool operator == (Point3D p1, Point3D p2)
        {

            return (p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z);
        }
        public static bool operator !=(Point3D p1, Point3D p2)
        {

            return  !(p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z);
        }
    }
    


}

