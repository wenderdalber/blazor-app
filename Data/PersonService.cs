using System;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Data
{
    public class PersonService
    {
        private static readonly string[] Summaries = new[]
        {
            "Minor", "Almost", "Adulthood"
        };

        public Task<Person[]> GetForecastAsync(DateTime startDate)
        {
            var random = new Random();
            return Task.FromResult(Enumerable.Range(1, 10).Select(index => new Person
            {
                Date = DateTime.Now,
                Birthday = DateTime.Now.AddYears(-index),
                Age = (DateTime.Now.AddYears(index).Year - DateTime.Now.Year),
                Summary = ((DateTime.Now.AddYears(index).Year - DateTime.Now.Year)) > 5 ? Summaries[2] : Summaries[1]
            }).ToArray());

        }
    }
}
