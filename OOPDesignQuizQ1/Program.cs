using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using System.IO;

namespace OOPDesignQuizQ1
{
    class Program
    {
        public abstract class TrainRide
        {
            public FeeBehaviour feeBehavior;
            public TrainRide()
            {

            }
            public double performGetCost()
            {
                return feeBehavior.calculateFee();
            }
            public void setCostBehavior(FeeBehaviour Fb)
            {
                feeBehavior = Fb;
            }
        }
        public interface FeeBehaviour
        {
            double calculateFee();
        }
        public class January : TrainRide
        {
            public int MonthValue = 1;
            public January()
            {
                setCostBehavior(new GetJanuaryCost());
            }
        }
        public class GetJanuaryCost : FeeBehaviour
        {
            public double calculateFee()
            {
                var price = Int32.Parse(ConfigurationManager.AppSettings.Get("Price"));
                var cost = price;
                return cost;
            }
        }
        public class February : TrainRide
        {
            public int MonthValue = 2;
            public February()
            {
                setCostBehavior(new GetFebruaryCost());
            }
        }
        public class GetFebruaryCost : FeeBehaviour
        {
            public double calculateFee()
            {
                var price = Int32.Parse(ConfigurationManager.AppSettings.Get("Price"));
                var cost = price;
                return cost;
            }
        }
        public class March : TrainRide
        {
            public int MonthValue = 3;
            public March()
            {
                setCostBehavior(new GetMarchCost());
            }
        }
        public class GetMarchCost : FeeBehaviour
        {
            public double calculateFee()
            {
                var price = Int32.Parse(ConfigurationManager.AppSettings.Get("Price"));
                var cost = price;
                return cost;
            }
        }
        public class April : TrainRide
        {
            public int MonthValue = 4;
            public April()
            {
                setCostBehavior(new GetAprilCost());
            }
        }
        public class GetAprilCost : FeeBehaviour
        {
            public double calculateFee()
            {
                var price = Int32.Parse(ConfigurationManager.AppSettings.Get("Price"));
                var cost = price;
                return cost;
            }
        }
        public class May : TrainRide
        {
            public int MonthValue = 5;
            public May()
            {
                setCostBehavior(new GetMayCost());
            }
        }
        public class GetMayCost : FeeBehaviour
        {
            public double calculateFee()
            {
                var price = Int32.Parse(ConfigurationManager.AppSettings.Get("Price"));
                var cost = price;
                return cost;
            }
        }
        public class June : TrainRide
        {
            public int MonthValue = 6;
            public June()
            {
                setCostBehavior(new GetJuneCost());
            }
        }
        public class GetJuneCost : FeeBehaviour
        {
            public double calculateFee()
            {
                var price = Int32.Parse(ConfigurationManager.AppSettings.Get("Price"));
                var cost = price / 1.25;
                return cost;
            }
        }
        public class July : TrainRide
        {
            public int MonthValue = 7;
            public July()
            {
                setCostBehavior(new GetJulyCost());
            }
        }
        public class GetJulyCost : FeeBehaviour
        {
            public double calculateFee()
            {
                var price = Int32.Parse(ConfigurationManager.AppSettings.Get("Price"));
                var cost = price / 1.25;
                return cost;
            }
        }
        public class August : TrainRide
        {
            public int MonthValue = 8;
            public August()
            {
                setCostBehavior(new GetAugustCost());
            }
        }
        public class GetAugustCost : FeeBehaviour
        {
            public double calculateFee()
            {
                var price = Int32.Parse(ConfigurationManager.AppSettings.Get("Price"));
                var cost = price;
                return cost;
            }
        }
        public class September : TrainRide
        {
            public int MonthValue = 9;
            public September()
            {
                setCostBehavior(new GetSeptemberCost());
            }
        }
        public class GetSeptemberCost : FeeBehaviour
        {
            public double calculateFee()
            {
                var price = Int32.Parse(ConfigurationManager.AppSettings.Get("Price"));
                var cost = price;
                return cost;
            }
        }
        public class October : TrainRide
        {
            public int MonthValue = 10;
            public October()
            {
                setCostBehavior(new GetOctoberCost());
            }
        }
        public class GetOctoberCost : FeeBehaviour
        {
            public double calculateFee()
            {
                var price = Int32.Parse(ConfigurationManager.AppSettings.Get("Price"));
                var cost = price;
                return cost;
            }
        }
        public class November : TrainRide
        {
            public int MonthValue = 11;
            public November()
            {
                setCostBehavior(new GetMayCost());
            }
        }
        public class GetNovemberCost : FeeBehaviour
        {
            public double calculateFee()
            {
                var price = Int32.Parse(ConfigurationManager.AppSettings.Get("Price"));
                var cost = price;
                return cost;
            }
        }
        public class December : TrainRide
        {
            public int MonthValue = 12;
            public December()
            {
                setCostBehavior(new GetDecemberCost());
            }
        }
        public class GetDecemberCost : FeeBehaviour
        {
            public double calculateFee()
            {
                var price = Int32.Parse(ConfigurationManager.AppSettings.Get("Price"));
                var cost = price * 2;
                return cost;
            }
        }
        static void Main(string[] args)
        {
            string path = @"D:\Example\Example.txt";


            December december = new December();
            Console.WriteLine(december.performGetCost());
            July july = new July();
            Console.WriteLine(july.performGetCost());
            Console.ReadLine();
            using (StreamReader sr = File.OpenText(path))
            {
                string s = " ";
                while((s = sr.ReadLine()) != null)
                {
                    File.AppendAllText(path, december.performGetCost().ToString());
                    File.AppendAllText(path, december.MonthValue.ToString());
                    sr.Close();
                }
            }
        }
    }
}
