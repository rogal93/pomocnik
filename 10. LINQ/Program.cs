using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Przyklad nr 1

            //Wyrazenie zapytan LINQ
            IEnumerable<CultureInfo> commaCultures1 =
                from culture in CultureInfo.GetCultures(CultureTypes.AllCultures)
                where culture.NumberFormat.NumberDecimalSeparator == ","
                select culture;

            //foreach (CultureInfo culture in commaCultures1)
            //{
            //    Console.WriteLine(culture.Name);
            //}

            #endregion
            #region Przyklad nr 2 - (nr 1, ale tylko jedna wlasciwosc)
            
            //kolekcja <string> bo biore same nazwy kultur
            IEnumerable<string> commaCultures2 =
                from culture in CultureInfo.GetCultures(CultureTypes.AllCultures)
                where culture.NumberFormat.NumberDecimalSeparator == ","
                select culture.Name;

            #endregion
            #region Przyklad nr 2 po konwersji

            IEnumerable<string> commaCultures3 =
                CultureInfo.GetCultures(CultureTypes.AllCultures)
                .Where(culture => culture.NumberFormat.NumberDecimalSeparator == ",")
                .Select(culture => culture.Name);

            #endregion

            #region Klauzula LET

            IEnumerable<string> commaCultures4 =
                from culture in CultureInfo.GetCultures(CultureTypes.AllCultures)
                let numFormat = culture.NumberFormat
                where numFormat.NumberDecimalSeparator == ","
                select culture.Name;

            #endregion

            #region WHERE z indeksem

            //wypisze rekordy z parzystymi indeksami i z trwaniem niemniejszym niz 3h 
            IEnumerable<Course> q = Course.Catalog
                .Where((course, index) => (index % 2 == 0) && course.Duration.TotalHours >= 3);

            #endregion

            #region SELECT z indeksem

            IEnumerable<string> nonIntro = Course.Catalog
                .Select((course, index) => string.Format("Kurs {0}: {1}", index + 1, course.Title));

            #endregion
            #region SELECT z indeksem, ale operujacy na wynikach WHERE

            IEnumerable<string> nonIntro1 = Course.Catalog
                .Where(c => c.Number >= 200)
                .Select((course, index) => string.Format("Kurs {0}: {1}", index, course.Title));

            #endregion
            #region SELECT korzystająca z typu anonimowego

            //var pq = from product in dbCtx.Products
            //         where (product.ListPrice > 3000)
            //         select new { product.Name, product.ListPrice, product.Size };

            #endregion
            #region SELECT przeksztalcajacy liczby

            int[] numbers = { 0, 1, 2, 3, 4, 5 };

            IEnumerable<int> doubled = numbers.Select(x => 2 * x);
            IEnumerable<int> squared = numbers.Select(x => x * x);
            IEnumerable<string> numberText = numbers.Select(x => x.ToString());

            #endregion
            #region SELECT splaszczenie tablicy

            int[][] arrays = 
            {
                new[] { 1, 2 },
                new[] { 1, 2, 3, 4, 5, 6 },
                new[] { 1, 2, 4 },
                new[] { 1 },
                new[] { 1, 2, 3, 4, 5 }
            };

            IEnumerable<int> combined2 = from item in arrays
                                         from number in item
                                         select number;

            #endregion
            #region SELECT + DISTINCT

            var categories = Course.Catalog.Select(c => c.Category).Distinct();

            #endregion

            #region SelectMany zapytanie (iloczyn kartezjanski)

            int[] numbers1 = { 1, 2, 3, 4, 5 };
            string[] letters = { "A", "B", "C" };

            IEnumerable<string> combined = from number in numbers1
                                           from letter in letters
                                           select letter + number;
            #endregion
            #region SelectMany operator

            combined = numbers1.SelectMany(number => letters,
                (number, letter) => letter + number);

            //foreach (string s in combined)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion

            #region ORDERBY

            var q1 = from course in Course.Catalog
                    orderby course.PublicationDate ascending //descending
                    select course;

            #endregion
            #region ORDERBY kilka kryteriow

            var q2 = from course in Course.Catalog
                     orderby course.PublicationDate ascending, course.Duration descending
                     select course;

            #endregion
            #region ORDERBY operator i dwa kryteria

            var q3 = Course.Catalog
                .OrderBy(course => course.PublicationDate)
                .ThenByDescending(course => course.Duration);

            #endregion

            #region SINGLE - gdy zapytanie zwraca jeden wynik

            var q4 = from course in Course.Catalog
                     where course.Category == "MAT" && course.Number == 101
                     select course;

            Course geometry = q4.Single();

            #endregion
            #region SINGLE operator z predykatem

            Course geometry1 = Course.Catalog.Single(
                course => course.Category == "MAT" && course.Number == 101);

            #endregion

            #region FIRST (Last) - sortowanie i pozniej wziecie pierwszego (ostatniego) rekordu

            var q5 = from course in Course.Catalog
                     orderby course.Duration descending
                     select course;

            Course longest = q5.First();

            //analogicznie z Last()

            #endregion
            #region TAKE i SKIP operatory

            int[] numbers2 = { 1, 2, 3, 4, 5 };
            IEnumerable<int> threeOfThose = numbers2.Take(3);
            IEnumerable<int> lastTwo = numbers.Skip(3);

            #endregion

            #region AGREGATION (AVERAGE, MAX, MIN, SUM)

            double average = Course.Catalog.Average(course => course.Duration.TotalHours);
            double max = Course.Catalog.Max(course => course.Duration.TotalHours);
            double min = Course.Catalog.Min(course => course.Duration.TotalHours);
            double sum = Course.Catalog.Sum(course => course.Duration.TotalHours);

            #endregion

            #region ZIP lączenie list

            string[] firstNames = { "Jan", "Artur", "Czesław" };
            string[] lastNames = { "Kowalski", "Zieliński", "Wielicki" };

            IEnumerable<string> fullNames = firstNames.Zip(lastNames, 
                (first, last) => first + " " + last
                );

            //foreach (var item in fullNames)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region GRUPOWANIE

            //grupowanie kursow po kategoriach
            var subjectGroups = from course in Course.Catalog
                                group course by course.Category;

            //to samo ale przy pomocy zapytania
            var subjectGroups2 = Course.Catalog.GroupBy(course => course.Category);

            //foreach (var group in subjectGroups)
            //{
            //    Console.WriteLine("Kategoria: " + group.Key);
            //    Console.WriteLine();

            //    foreach (var course in group)
            //    {
            //        Console.WriteLine(course.Title);
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region GRUPOWANIE z projekcją

            //zwraca same tytuly (zamiast calych kursow) pogrupowane wg kategorii
            var subjectGroups3 = from course in Course.Catalog
                                group course.Title by course.Category;

            //to samo przy pomocy zapytania
            var subjectGroups4 = Course.Catalog.GroupBy(course => course.Category,
                course => course.Title);

            //foreach (var group in subjectGroups3)
            //{
            //    Console.WriteLine("Kategoria: " + group.Key);
            //    Console.WriteLine();

            //    foreach (var course in group)
            //    {
            //        Console.WriteLine(course);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Enumerable.Range i Enumerable.Repeat

            int[] zakres = Enumerable.Range(10, 15).ToArray();
            int[] powtorzone = Enumerable.Repeat(10, 15).ToArray();

            //foreach (var item in powtorzone)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            Console.ReadKey();
        }

        #region Operator OfType<T>
        //zwraca elementy danego typu
        static void ShowAllStrings(IEnumerable<object> src)
        {
            var strings = src.OfType<string>();
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }
        #endregion

    }
}
