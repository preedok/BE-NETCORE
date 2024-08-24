using BCrypt.Net;

namespace UserApiDotnet.Helpers
{
    public static class PasswordHasher
    {
        // Hash password dengan BCrypt
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        // Verifikasi password dengan BCrypt
        public static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
