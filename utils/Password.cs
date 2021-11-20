using BC = BCrypt.Net.BCrypt;

using Charming_house.utils;

namespace Charming_house.utils
{
    public class Password
    {
        
        public static string Encript(string senha){
            return BC.HashPassword(senha);
        }

        public static bool Validate(string senha, string hash){
            try
            {
                return BC.Verify( senha, hash );
            }
            catch (System.Exception error)
            {
                Logger.Warn(error.Message);
                return false;
            }
            
        }

    }
}