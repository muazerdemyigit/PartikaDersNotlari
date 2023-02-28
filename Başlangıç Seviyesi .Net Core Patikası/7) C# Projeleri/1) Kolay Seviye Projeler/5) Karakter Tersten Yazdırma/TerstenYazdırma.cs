namespace _5__Karakter_Tersten_Yazdırma;

public class TerstenYazdırma
{
    public string[] TersCevir(string[] arr)
    {
        string[] yeniKelimeler = new string[arr.Length]; 
        int s = 0;
        foreach (var kelime in arr) 
        {

            int i = 0;
            char[] harfler = new char[kelime.Length]; 
            foreach (var harf in kelime)
            {

                harfler[i] = harf;
                i++;

            }
            char ilk = harfler[0]; 
            for (int j = 0; j < harfler.Length - 1; j++)
            {
                harfler[j] = harfler[j + 1]; 
                harfler[j + 1] = ilk;
            }
            string yenikelime = "";
            foreach (var item in harfler)
            {
                yenikelime += item;
            }
            yeniKelimeler[s] = yenikelime;
            s++;

        }
        return yeniKelimeler;

    }

    public void KelimeleriYazdırma(string[] arr)
    {
        foreach (var kelimeler in arr)
        {
            System.Console.WriteLine(kelimeler + " ");
        }
    }
}
