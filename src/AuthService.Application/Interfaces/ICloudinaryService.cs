namespace AuthService.Application.Interfaces;

public interface IcloudinaryService
{
    Task<string> UploadImageAsync(IFileData imagenFile, string fileName);
    Task<bool> DeleteImageAsync(string publicId);
    string GetDefaultAvatarUrl();
    string GetFullIImageUrl(string imagePath);
}