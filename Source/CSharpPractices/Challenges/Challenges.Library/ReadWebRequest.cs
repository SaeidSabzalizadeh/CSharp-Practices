using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Net;
using Newtonsoft.Json;


namespace Challenges.Library
{
    public class ReadWebRequest
    {

        //    string sample = @"
        //{"page":1,"per_page":10,"total":99,"total_pages":10,"data":[{"id":1,"timestamp":1565637002408,"diagnosis":{"id":3,"name":"Pulmonary embolism","severity":4},"vitals":{"bloodPressureDiastole":154,"bloodPressureSystole":91,"pulse":125,"breathingRate":32,"bodyTemperature":100},"doctor":{"id":2,"name":"Dr Arnold Bullock"},"userId":2,"userName":"Bob Martin","userDob":"14-09-1989","meta":{"height":174,"weight":172}},{"id":2,"timestamp":1562539731129,"diagnosis":{"id":4,"name":"Pleurisy","severity":3},"vitals":{"bloodPressureDiastole":139,"bloodPressureSystole":81,"pulse":104,"breathingRate":20,"bodyTemperature":99.4},"doctor":{"id":2,"name":"Dr Arnold Bullock"},"userId":2,"userName":"Bob Martin","userDob":"14-09-1989","meta":{"height":174,"weight":171}},{"id":3,"timestamp":1563465027370,"diagnosis":{"id":2,"name":"Common Cold","severity":1},"vitals":{"bloodPressureDiastole":125,"bloodPressureSystole":76,"pulse":113,"breathingRate":22,"bodyTemperature":100.8},"doctor":{"id":4,"name":"Dr Allysa Ellis"},"userId":2,"userName":"Bob Martin","userDob":"14-09-1989","meta":{"height":174,"weight":185}},{"id":4,"timestamp":1561018581520,"diagnosis":{"id":4,"name":"Pleurisy","severity":3},"vitals":{"bloodPressureDiastole":138,"bloodPressureSystole":80,"pulse":124,"breathingRate":22,"bodyTemperature":97},"doctor":{"id":2,"name":"Dr Arnold Bullock"},"userId":4,"userName":"Francesco De Mello","userDob":"02-05-1994","meta":{"height":183,"weight":185}},{"id":5,"timestamp":1557725281296,"diagnosis":{"id":3,"name":"Pulmonary embolism","severity":4},"vitals":{"bloodPressureDiastole":153,"bloodPressureSystole":99,"pulse":124,"breathingRate":34,"bodyTemperature":102.5},"doctor":{"id":4,"name":"Dr Allysa Ellis"},"userId":4,"userName":"Francesco De Mello","userDob":"02-05-1994","meta":{"height":183,"weight":210}},{"id":6,"timestamp":1568550058964,"diagnosis":{"id":3,"name":"Pulmonary embolism","severity":4},"vitals":{"bloodPressureDiastole":155,"bloodPressureSystole":90,"pulse":130,"breathingRate":29,"bodyTemperature":99.2},"doctor":{"id":2,"name":"Dr Arnold Bullock"},"userId":1,"userName":"John Oliver","userDob":"02-01-1986","meta":{"height":168,"weight":173}},{"id":7,"timestamp":1564691138999,"diagnosis":{"id":3,"name":"Pulmonary embolism","severity":4},"vitals":{"bloodPressureDiastole":147,"bloodPressureSystole":100,"pulse":138,"breathingRate":25,"bodyTemperature":100},"doctor":{"id":3,"name":"Dr Pilar Cristancho"},"userId":1,"userName":"John Oliver","userDob":"02-01-1986","meta":{"height":168,"weight":196}},{"id":8,"timestamp":1562157191823,"diagnosis":{"id":2,"name":"Common Cold","severity":1},"vitals":{"bloodPressureDiastole":122,"bloodPressureSystole":77,"pulse":91,"breathingRate":20,"bodyTemperature":101.5},"doctor":{"id":3,"name":"Dr Pilar Cristancho"},"userId":1,"userName":"John Oliver","userDob":"02-01-1986","meta":{"height":168,"weight":175}},{"id":9,"timestamp":1548036340751,"diagnosis":{"id":3,"name":"Pulmonary embolism","severity":4},"vitals":{"bloodPressureDiastole":147,"bloodPressureSystole":96,"pulse":130,"breathingRate":28,"bodyTemperature":101},"doctor":{"id":2,"name":"Dr Arnold Bullock"},"userId":3,"userName":"Helena Fernandez","userDob":"23-12-1987","meta":{"height":157,"weight":106}},{"id":10,"timestamp":1562161672195,"diagnosis":{"id":2,"name":"Common Cold","severity":1},"vitals":{"bloodPressureDiastole":127,"bloodPressureSystole":78,"pulse":130,"breathingRate":22,"bodyTemperature":103.8},"doctor":{"id":4,"name":"Dr Allysa Ellis"},"userId":3,"userName":"Helena Fernandez","userDob":"23-12-1987","meta":{"height":157,"weight":110}}]}";

        /*
         * Complete the 'getRecordsByAgeGroup' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER ageStart
         *  2. INTEGER ageEnd
         *  3. INTEGER bpDiff
         *
         *  https://jsonmock.hackerrank.com/api/medical_records
         */

        public static void Run()
        {
            var ids = getRecordsByAgeGroup(40, 45, 5);
            Console.WriteLine($"IDS: {string.Join(" ,", ids)}");

        }


        public static List<int> getRecordsByAgeGroup(int ageStart, int ageEnd, int bpDiff)
        {
            List<MedicalRecord> records = GetAllMedicalRecords("https://jsonmock.hackerrank.com/api/medical_records");
            List<int> result = records?
                        .Where(x => ageStart <= x.age)
                        .Where(x => ageEnd >= x.age)
                        .Where(x => x.bpDiff > bpDiff)
                        .Select(x => x.id)
                        .OrderBy(x => x)
                        .Distinct()
                        .ToList();

            if (result == null || !result.Any())
                result = new List<int>() { -1 };

            return result;

        }

        public static List<MedicalRecord> GetAllMedicalRecords(string url)
        {
            string mainUrl = url;
            int totalPages = 0;
            int currentPage = 0;

            List<List<MedicalRecord>> allrecords = new List<List<MedicalRecord>>();
            ResultMedicalRecord result = GetRequest(url);
            allrecords.Add(result.data.ToList());
            totalPages = result.total_pages;
            currentPage = result.page;

            if (totalPages > 1)
            {
                while (currentPage < totalPages)
                {
                    string currentUrl = mainUrl + $"?page={currentPage + 1}";
                    ResultMedicalRecord currentResult = GetRequest(currentUrl);
                    currentPage = currentResult.page;
                    allrecords.Add(result.data.ToList());
                }
            }

            return allrecords.SelectMany(x => x).ToList();


        }

        public static ResultMedicalRecord GetRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<ResultMedicalRecord>(result);

            }
        }

        public class ResultMedicalRecord
        {
            public int page { get; set; }
            public int per_page { get; set; }
            public int total { get; set; }
            public int total_pages { get; set; }
            public MedicalRecord[] data { get; set; }
        }

        public class MedicalRecord
        {
            public int id { get; set; }
            public int userId { get; set; }
            public string userDob { get; set; }
            public DateTime userDobDateTime => new DateTime(int.Parse(userDob.Substring(6, 4)), int.Parse(userDob.Substring(3, 2)), int.Parse(userDob.Substring(0, 2)));
            public Vital vitals { get; set; }
            public object diagnosis { get; set; }
            public object doctor { get; set; }
            public object meta { get; set; }
            internal int age => (int)((DateTime.Now - userDobDateTime).TotalDays / 365);
            internal float bpDiff => vitals.bloodPressureDiastole - vitals.bloodPressureSystole;
        }

        public class Vital
        {
            public float bloodPressureDiastole { get; set; }
            public float bloodPressureSystole { get; set; }
            public int pulse { get; set; }
            public int breathingRate { get; set; }
            public float bodyTemperature { get; set; }
        }

    }

}
//class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int ageStart = Convert.ToInt32(Console.ReadLine().Trim());

//        int ageEnd = Convert.ToInt32(Console.ReadLine().Trim());

//        int bpDiff = Convert.ToInt32(Console.ReadLine().Trim());

//        List<int> result = Result.getRecordsByAgeGroup(ageStart, ageEnd, bpDiff);

//        textWriter.WriteLine(String.Join("\n", result));

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
