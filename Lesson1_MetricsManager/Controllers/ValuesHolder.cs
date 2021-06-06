using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1_MetricsManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesHolder : IValuesHolder
    {
        public List<Temperature> tempData = new List<Temperature>();
        public ValuesHolder() { }

        private Temperature Create(string tempC, DateTime time)
        {
            var temp = new Temperature()
            {
                TempC = tempC,
                Time = time
            };
            return temp;
        }

        public void Add(string tempС, DateTime time)
        {
            var temp = Create(tempС, time);
            tempData.Add(temp);
        }

        public void Delete(DateTime firstTime, DateTime secondTime)
        {
            List<Temperature> GetTempFromDate = new List<Temperature>();
            tempData.Sort(delegate (Temperature x, Temperature y) { return x.Time.CompareTo(y.Time); });

            foreach (var item in tempData)
            {
                if (item.Time >= firstTime && item.Time <= secondTime)
                {
                    GetTempFromDate.Add(item);
                }
            }
            if (GetTempFromDate.Count > 0)
            {
                foreach (var item in GetTempFromDate)
                {
                    tempData.Remove(item);
                }
            }
        }

        public object Get(DateTime firstTime, DateTime secondTime)
        {
            List<string> GetTempFromDate = new List<string>();
            tempData.Sort(delegate (Temperature x, Temperature y) { return x.Time.CompareTo(y.Time); });

            foreach (var item in tempData)
            {
                if (item.Time >= firstTime && item.Time <= secondTime)
                {
                    string time = item.Time.ToString("HH:mm:ss");
                    string result = item.TempC + " градусов в " + time;
                    GetTempFromDate.Add(result);
                }

            }
            return GetTempFromDate;
        }

        public void Update(string tempC, DateTime time)
        {
            var temp = Create(tempC,time);
            foreach (var item in tempData)
            {
                if (item.Time == temp.Time)
                {
                    tempData.Remove(item);
                    tempData.Add(temp);
                    break;
                }
            }
        }
    }
}
