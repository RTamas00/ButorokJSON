using System.Text.Json;

namespace ButorokJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string file = File.ReadAllText("butorok.json");
                Gyoker gy =JsonSerializer.Deserialize<Gyoker>(file);
                //Mely bútorok vannak fából?
                foreach (var  t in gy .targyak)
                {
                    if (t.anyag.ToLower().Contains("fa"))
                    
                        Console.WriteLine(t);
                    
                }
                //Melyik bútornak van a legnagyobb térfogata?
                    Targyak max = gy.targyak[0];
                foreach (var targy in gy.targyak)
                    {
                    if (targy.terfogat() > max.terfogat())
                        max = targy;
                }
                Console.WriteLine("Legnagyobb: " + max);
                //A készleten lévők összára mennyi ?
            }
            catch (JsonException ex)
            {
                Console.WriteLine("JSON fálj feldolgozási hiba: " + ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Elérésiút hiba: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Fáljkezelési hiba: " + ex.Message);
            }
            catch (Exception ex) { 
             Console.WriteLine("Fáljkezelési hiba: " + ex.Message);
            }

           
        }
    }
}
