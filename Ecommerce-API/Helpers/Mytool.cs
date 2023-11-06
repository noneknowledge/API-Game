namespace Ecommerce_API.Helpers
{
    public class Mytool
    {
        public static string UploadImageToFolder(IFormFile myfile, string folder = "Products")

        {
            try
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", folder, myfile.FileName);
                using (var newFile = new FileStream(filePath, FileMode.Create))
                {
                    myfile.CopyTo(newFile);
                }
                return myfile.FileName;
            }
            catch (Exception ex)
            {
                return string.Empty;
            }

        }
    }
}
