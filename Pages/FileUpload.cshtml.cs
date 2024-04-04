using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PetEmotionsApp.Models;
using PetEmotionsApp.Data;
using System.Globalization;

using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;


namespace PetEmotionsApp.Pages;
public class FileUploadModel : PageModel
{
    private readonly PetEmotionsAppContext _context;
    
    public FileUploadModel(PetEmotionsAppContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> OnPost(IFormFile FileUpload)
    {   
        using (var memoryStream = new MemoryStream())
        {
            await FileUpload.CopyToAsync(memoryStream);

            // Upload the file if less than 2 MB
            if (memoryStream.Length < 2097152)
            {
                var file = new FileUpload()
                {
                    FileContent = memoryStream.ToArray(),
                    fileDate = DateTime.UtcNow,
                };
            _context.FileUpload.Add(file);
            await _context.SaveChangesAsync();
            }
            else
            {
                ModelState.AddModelError("File", "The file is too large.");
            }
        }

    return Page();
    }
}