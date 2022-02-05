using Pierre.Fontaine.Ocr;

// C:\Images\image1.jpg
var imagePaths = args;

var images = new List<byte[]>();

foreach (var imagePath in imagePaths)
{
    try
    {
        var imageBytes = await File.ReadAllBytesAsync(imagePath);
        images.Add(imageBytes);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Catch exception : {ex.Message}");
    }
}

var ocrResults = await new Ocr().ReadAsync(images);

foreach (var ocrResult in ocrResults)
{
    Console.WriteLine($"Confidence :{ocrResult.Confidence}");
    Console.WriteLine($"Text :{ocrResult.Text}");
}