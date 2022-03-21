using System;

namespace CursoCSharp.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }
    public class PrimeiroArquivo
    {
        public static void Executar()
        {
            var path = @"~primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                using StreamWriter sw = File.CreateText(path);
                sw.WriteLine("API é");
                sw.WriteLine("dificil demais");
                sw.WriteLine("mas não vou desistir");
                sw.WriteLine("Deus há de me ajudar");
            }
        }
    }
}
