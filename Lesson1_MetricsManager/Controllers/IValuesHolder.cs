using System;

namespace Lesson1_MetricsManager.Controllers
{
    public interface IValuesHolder
    {
        void Add(string tempC, DateTime time);
        void Update(string tempC, DateTime time);
        object Get(DateTime firstTime, DateTime secondTime);
        void Delete(DateTime firstTime, DateTime secondTime);
    }
}