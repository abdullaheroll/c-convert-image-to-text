using IronOcr; //TR: Gerekli Kütüphane.  //EN: Required Library.

namespace ConvertTextToImage
{
    
    class Program
    {

        static void Main(string[] args)
        {
            var ocr = new IronTesseract();
            ocr.Language = OcrLanguage.Turkish; //TR: Gerekli Kütüphane.  //EN: Required Library.
            using (var input = new OcrInput(@"C:\Users\Apo\Desktop\image.jpg")) //TR: Metne çevirilecek görsel. //EN: The image to be converted to text.
            {
                var result = ocr.Read(input);
                result.SaveAsTextFile(@"C:\Users\Apo\Desktop\6.txt");  //TR: .txt uzantılı olarak kayıt eder. //EN: It saves as .txt extension.
                result.SaveAsSearchablePdf(@"C:\Users\Apo\Desktop\6.pdf"); //TR: .pdf uzantılı olarak kayıt eder. //EN: It saves as .pdf extension.
            }
        }

    }
}
