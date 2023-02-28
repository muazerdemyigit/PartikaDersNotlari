namespace _5__Karakter_Tersten_Yazdırma;
class Program
{
    static void Main(string[] args)
    {
        /*
        Algoritma
            Verilen string ifade içerisindeki karakterleri bir önceki karakter ile yer değiştiren console uygulamasını yazınız.

            Örnek: Input: Merhaba Hello Question

            Output: erhabaM elloH uestionQ
        
        */

        Konsol_Islemleri konsol = new Konsol_Islemleri();
        TerstenYazdırma terstenYazdırma = new TerstenYazdırma();
        konsol.GirisMesaji();
        string[] cumleler = konsol.CumleleriAlma();
        string[] YeniCumleler = terstenYazdırma.TersCevir(cumleler);
        terstenYazdırma.KelimeleriYazdırma(YeniCumleler);
    }
}
