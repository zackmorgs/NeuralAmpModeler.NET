namespace Server.Services;

using System;
using Server.Data;
using Server.Models;

public class NamFileService
{
    public NamFileService(NAMDb context)
    {   
        _context = context;
    }

    private readonly NAMDb _context;

    public async Task StoreFileAsync(string filePath, string fileName, int uploadedById, bool isPublic)
    {
        byte[] fileData = await File.ReadAllBytesAsync(filePath);
        var fileSize = new FileInfo(filePath).Length;

        var namFile = new NAMFile
        {
            FileName = fileName,
            FileSize = fileSize,
            UploadedById = uploadedById,
            IsPublic = isPublic,
            FileContent = fileData
        };
    }
}