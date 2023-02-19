using WorkForceManagement.web.Models;

namespace WorkForceManagement.web.Helpers;

public class ImageHelper
{
    public static string SaveImage(IFormFile profileImage)
    {
        // Save profile Image to some Location
        var fileName=profileImage.FileName;
        var uniqueFilename = $"{Guid.NewGuid()}_{fileName}";
        var relativePath =$"/image/profiles/{uniqueFilename}";
        var currentAppPath = Directory.GetCurrentDirectory();
        var fullFilepath = Path.Combine(currentAppPath, $"wwwroot/{relativePath}");

        using var stream = File.Create(fullFilepath);
        profileImage.CopyTo(stream);
        

        //Return relative path to save to DB
        return relativePath;
        
    }
}
