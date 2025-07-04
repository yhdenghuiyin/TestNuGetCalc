using Newtonsoft.Json;

namespace TestNuGetCalc
{
    public class CalcHelper: ICalcHelper
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public string AddForJson(int a, int b)
        {
            return JsonConvert.SerializeObject(new
            {
                Code = 0,
                Msg = "Sucess",
                Type = "Add",
                Data = a + b
            });
        }

        public string SubtractForJson(int a, int b)
        {
            return JsonConvert.SerializeObject(new
            {
                Code = 0,
                Msg = "Sucess",
                Type = "Subtract",
                Data = a - b
            });
        }
    }
}
